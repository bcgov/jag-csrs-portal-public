using Csrs.Interfaces;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Exceptions;
using System;

namespace Csrs.Services.FileManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
            {
                loggerConfiguration
                    .ReadFrom.Configuration(builder.Configuration)
                    .Enrich.WithExceptionDetails(/* to add destructurers */);

                var collectorUrl = builder.Configuration["SPLUNK_URL"];
                if (string.IsNullOrEmpty(collectorUrl))
                {
                    // fall back to previous variable
                    collectorUrl = builder.Configuration["SPLUNK_COLLECTOR_URL"];
                }
                var token = builder.Configuration["SPLUNK_TOKEN"];

                if (!string.IsNullOrEmpty(collectorUrl) && !string.IsNullOrEmpty(token))
                {
                    loggerConfiguration
                        .WriteTo.EventCollector(splunkHost: collectorUrl, eventCollectorToken: token, sourceType: "Csrs.Services.FileManager");
                }

                Serilog.Debugging.SelfLog.Enable(Console.Error);
            });

            builder.Services.AddSharePointIntegration();

            builder.Services.AddGrpc(options =>
            {
                options.EnableDetailedErrors = true;
                options.MaxReceiveMessageSize = null; // disable limit
                options.MaxSendMessageSize = null; // disable limit
            });

            // health checks. 
            builder.Services.AddHealthChecks()
                .AddCheck("file-manager-service", () => HealthCheckResult.Healthy("OK"));

            builder.UseOpenShiftIntegration(_ => _.CertificateMountPoint = "/var/run/secrets/service-cert");

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseHealthChecks("/hc/ready", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseHealthChecks("/hc/live", new HealthCheckOptions
            {
                // Exclude all checks and return a 200-Ok.
                Predicate = _ => false
            });

            app.MapGrpcService<FileManagerService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();

        }
    }
}