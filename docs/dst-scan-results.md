# DST Impact Scan — CSRS Portal (OpenShift)

**Date:** 2026-08-10  
**Branch:** CSRS-653_sharepoint_create_folder  
**Scope:** Application code, container configuration, OpenShift deployment manifests, scheduled jobs, integrations, date/time libraries

---

## Summary

| Area                                     | Status  | Issues Found           | Remediated         |
| ---------------------------------------- | ------- | ---------------------- | ------------------ |
| Backend C# (.NET 6)                      | Scanned | 3 confirmed DST issues | ✅ All fixed       |
| Frontend Angular (TypeScript)            | Scanned | 1 advisory (low risk)  | No action required |
| OpenShift deployment YAMLs               | Scanned | No TZ env var set      | Advisory only      |
| Dockerfiles (API, FileManager, Frontend) | Scanned | None                   | —                  |
| Scheduled / batch jobs (CronJobs)        | Scanned | None found             | —                  |
| Dynamics CRM integration                 | Scanned | None                   | —                  |
| SharePoint integration                   | Scanned | None                   | —                  |
| Logging (Serilog)                        | Scanned | None                   | —                  |

---

## Confirmed Issues — Remediated

### Issue 1 — DST-sensitive filename timestamp (HIGH)

**File:** `src/backend/Csrs.Api/Extensions/FileSystemItemExtensions.cs`, line 45  
**Method:** `CombineNameDocumentType`

**Before:**

```csharp
name = tmp + DateTime.Now.ToString("_yyyyMMddhhmmss") + ext;
```

**Problem:** `DateTime.Now` returns local time. In a container whose system timezone could drift or change, or during a DST clock-back, two distinct uploads within the same ambiguous hour could produce identical filenames, silently overwriting documents. Additionally, `hh` is the 12-hour clock format — 1:05 AM and 1:05 PM produce the same suffix.

**Fix applied:**

```csharp
name = tmp + DateTime.UtcNow.ToString("_yyyyMMddHHmmss") + ext;
```

`DateTime.UtcNow` is monotonically unambiguous across DST transitions. `HH` (24-hour) eliminates AM/PM collisions.

---

### Issue 2 — DST-sensitive submission timestamp (HIGH)

**File:** `src/backend/Csrs.Api/Models/ModelExtensions.cs`, line 152  
**Method:** `ToDynamicsModel(File file)`

**Before:**

```csharp
SsgSubmissiondate = new DateTimeOffset(DateTime.Now)
```

**Problem:** `DateTime.Now` is local time. `new DateTimeOffset(DateTime)` when given a `DateTime` with `Kind == Local` captures the current local UTC offset (e.g., `-07:00` in PDT or `-08:00` in PST). During the fall-back transition the clock repeats one hour, so two submissions 30 minutes apart can receive timestamps that appear chronologically reversed after conversion to UTC. This also means the stored offset is environment-dependent rather than canonical.

**Fix applied:**

```csharp
SsgSubmissiondate = DateTimeOffset.UtcNow
```

`DateTimeOffset.UtcNow` always has offset `+00:00` and is unambiguous.

---

### Issue 3 — DST-sensitive certificate expiry calculation (MEDIUM)

**File:** `src/backend/Csrs.Services.FileManager/OpenShiftIntegration/OpenShiftCertificateExpiration.cs`, lines 52–53  
**Class:** `OpenShiftCertificateExpiration` (BackgroundService)

**Before:**

```csharp
var expiresAt = certificate.NotAfter - NotAfterMargin; // NotAfter is in local time.
var tillExpires = expiresAt - DateTime.Now;
```

**Problem:** `X509Certificate2.NotAfter` is returned as `DateTime` with `Kind == Local`. `DateTime.Now` is also local. The subtraction is internally consistent in steady state, but during a DST fall-back the local clock moves backward one hour, creating an ambiguous `DateTime` in the skipped interval. `TimeSpan` arithmetic over a DST boundary can produce a `tillExpires` that is 1 hour longer or shorter than the true wall-clock duration. In a spring-forward scenario the service could restart 1 hour early; in a fall-back scenario it could restart 1 hour late, leaving the certificate expired without triggering a graceful restart.

**Fix applied:**

```csharp
var expiresAt = certificate.NotAfter.ToUniversalTime() - NotAfterMargin; // Use UTC to avoid DST ambiguity.
var tillExpires = expiresAt - DateTime.UtcNow;
```

Both operands are now UTC `DateTime` values (`.Kind == Utc`). Subtraction across DST boundaries is exact.

---

## Items Reviewed — No Action Required

### Backend: UTC-correct usages

| Location                                                      | Usage                                                 | Assessment  |
| ------------------------------------------------------------- | ----------------------------------------------------- | ----------- |
| `Csrs.Interfaces.SharePoint/TokenCache.cs`                    | `DateTimeOffset.UtcNow`                               | ✅ DST-safe |
| `Csrs.Interfaces.SharePoint/SamlAuthenticator.cs`             | `DateTimeStyles.AdjustToUniversal \| AssumeUniversal` | ✅ DST-safe |
| `Csrs.Interfaces.SharePoint/SharePointOnlineAuthenticator.cs` | `DateTimeOffset.UtcNow.AddSeconds(expiresIn)`         | ✅ DST-safe |
| `Csrs.Api/Services/TaskService.cs`                            | `DateTimeOffset.UtcNow`                               | ✅ DST-safe |
| `Csrs.Api/Features/UserRequests/Create.cs`                    | `DateTimeOffset.UtcNow`                               | ✅ DST-safe |
| `Csrs.Api/Features/Accounts/UpdateCSRSAccount.cs`             | `new DateTimeOffset(DateTime.UtcNow)`                 | ✅ DST-safe |
| `Csrs.Services.FileManager/Services/FileManagerService.cs`    | `DateTimeStyles.AssumeUniversal \| AdjustToUniversal` | ✅ DST-safe |

### Backend: Date-only fields (TryParse without explicit styles)

`ModelExtensions.ToDateTimeOffset` and `ModelExtensions.ToDateTime` use `TryParse` without `DateTimeStyles`. These are called only for date-only fields (date of birth, date of order/WA, registration date). Because DST shifts are ±1 hour and never cross a calendar day boundary at a date-only granularity, there is no realistic scenario in which a DST transition changes the parsed calendar date. **No action required.**

### Frontend Angular

| Location                                  | Usage                                         | Assessment                           |
| ----------------------------------------- | --------------------------------------------- | ------------------------------------ |
| API services (`account.service.ts`, etc.) | `(value as Date).toISOString().substr(0, 10)` | ⚠️ Advisory — see below              |
| `format-date.pipe.ts`                     | `new Date(y, m-1, d)` for display formatting  | ✅ Display-only, no persistence      |
| `child-application-question.component.ts` | Age calculation against `new Date()`          | ✅ Age is date-granularity, DST-safe |
| `ngx-material.module.ts`                  | `Intl.DateTimeFormatOptions` for display      | ✅ Display-only                      |

**Advisory — `toISOString().substr(0, 10)` in API services:**  
These services convert date picker values to ISO date strings for HTTP query parameters. `Date.toISOString()` converts to UTC before formatting. For date-only values (no time component), this is safe when the date is constructed via `new Date(year, month-1, day)` (which creates midnight local time). Since CSRS dates are calendar dates (birth dates, order dates), not timestamps, and the backend stores them as date-only values in Dynamics CRM, there is no practical DST risk. If a user in UTC-7 or UTC-8 were to select a date at exactly midnight and the HTTP serialization crossed the UTC date boundary, the discrepancy would be ±1 calendar day. However, the Material Date Picker does not carry a time component, so the constructed `Date` has time `00:00:00 local`, and `toISOString()` would only shift the date if the UTC offset pushes it past midnight (only possible for UTC+X offsets, not UTC-7/UTC-8 used in BC). **No change required; monitor if the application is ever used from UTC+ timezones.**

### OpenShift / Container Configuration

| Artifact                                        | Finding                                                                                                                            |
| ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| `Dockerfile` (API, RHEL8 variant)               | Base images (`mcr.microsoft.com/dotnet/aspnet:6.0`, `ubi8/dotnet-60-runtime`) default to UTC. No `TZ` env var set — acceptable.    |
| `Dockerfile` (FileManager)                      | Same as API.                                                                                                                       |
| `Dockerfile` (Frontend, nginx)                  | nginx base image defaults to UTC. JavaScript `Date` in the browser uses the **client browser's** local timezone, not the server's. |
| `jag-csrs-api.yml`, `jag-csrs-file-manager.yml` | No `TZ` environment variable configured. Containers will run in UTC (correct).                                                     |
| CronJobs / ScheduledJobs                        | None found in OpenShift manifests or application code. No DST-triggered scheduling risk.                                           |

---

## Residual Risks

| Risk                                                                                                                                                                                                                                             | Severity                     | Mitigation                                                                                                                      |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ---------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| If an OpenShift node or container image is ever reconfigured with a local timezone (e.g., `America/Vancouver`), the `ToDateTime` / `ToDateTimeOffset` helpers without explicit `DateTimeStyles` could parse date strings differently.            | Low                          | Explicitly set `TZ=UTC` (or `DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1`) in OpenShift deployment env vars as a defensive measure. |
| Client-browser date pickers in Angular construct `new Date()` in the user's local timezone. If a user in a UTC+ timezone (e.g., UTC+13 during NZ DST) submits a date at midnight local, `toISOString().substr(0,10)` returns the prior UTC date. | Very Low                     | Acceptable for current BC-focused userbase (UTC-7/UTC-8).                                                                       |
| `OpenShiftCertificateExpiration` do-while loop is implemented without the `do` keyword (pre-existing bug, unrelated to DST). If `Task.Delay(int.MaxValue)` completes and sets `loop=true`, the `while (loop);` becomes a CPU spin.               | Low (very large delays only) | Pre-existing; not in DST scope.                                                                                                 |

---

## Testing Checklist

- [ ] Submit a file via the portal; verify `SsgSubmissiondate` stored in Dynamics CRM has offset `+00:00`.
- [ ] Upload a document; verify the generated filename contains a 24-hour UTC timestamp (no duplicate filenames in rapid succession).
- [ ] Confirm FileManager container starts and logs certificate expiry in UTC (search logs for `Certificate expires at`).
- [ ] Perform a regression test of date-of-birth and date-of-order fields to confirm dates round-trip correctly through Dynamics CRM.
- [ ] Simulate a DST boundary (mock `DateTime.UtcNow` in unit tests) for `FileSystemItemExtensions.CombineNameDocumentType` and `ModelExtensions.ToDynamicsModel`.
