

# Configuration

Configuration uses standard .NET configuration system with convenience environment variable for simpler configuration. 
The convenience environment variable take presidence over other configuration sources. Additional environment variables
can be added by editing the CsrsEnvironmentVariablesConfigurationProvider class.

| Config Path | Environment Variable | Description |
|:---| --- |:---|
| Jwt:Audience | | The client id/resource of the application |
| Jwt:Authority | | The authentication server including the realm, ie https://dev.oidc.gov.bc.ca/auth/realms/onestopauth-basic |
| OAuth:AuthorizationUrl | | |
| OAuth:ResourceUrl | | |
| OAuth:ClientId | | |
| OAuth:Secret | | |
| OAuth:Username | | |
| OAuth:Password | | |
| Splunk:Url | SPLUNK_URL | The Splunk HEC url |
| Splunk:Token | SPLUNK_TOKEN | The Splunk HEC token |
| Splunk:ValidatServerCertificate | SPLUNK_VALIDATE_SERVER_CERTIFICATE | |

## User Secrets

Developers can use [User Secrets](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0) in 
their development environment to simplify configuration. For reference, the user secrets for the API project can be found
at this location.

%APPDATA%\Microsoft\UserSecrets\c672e48c-4fbd-4422-9e9e-e36f5e014384
