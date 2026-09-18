using Csrs.Api;
using Csrs.Api.Authentication;
using Csrs.Api.Configuration;
using Csrs.Api.Models;
using Csrs.Api.Services;
using Csrs.Api.ApiGateway;
using System.Configuration;
using Grpc.Net.Client;
using Grpc.Core;
using Grpc.Net.Client.Configuration;
using Serilog;
using Csrs.Interfaces.Dynamics;
using System.Net;

namespace Microsoft.Extensions.DependencyInjection;

public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// Adds repository and dependant services.
    /// </summary>
    /// <param name="builder"></param>
    public static void AddServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        var logger = Log.ForContext(typeof(WebApplicationBuilderExtensions));

        var configuration = builder.Configuration.Get<CsrsConfiguration>();
        DynamicsOptions? dynamicsOptions = configuration?.Dynamics;

        if (dynamicsOptions is null)
        {
            const string message = "Dynamics configuration is not set";
            logger.Error(message);
            throw new ConfigurationErrorsException(message);
        }

        ApiGatewayOptions? apiGatewayOptions = configuration?.ApiGateway;
        if (string.IsNullOrEmpty(apiGatewayOptions?.BasePath))
        {
            const string message = "ApiGateWay configuration is not set";
            logger.Error(message);
            throw new ConfigurationErrorsException(message);
        }

        var services = builder.Services;

        logger.Debug("Setting up dynamicsOptions and apiGatewayOptions");
        services.AddSingleton(dynamicsOptions);
        services.Configure<DynamicsOptions>(builder.Configuration.GetSection(nameof(CsrsConfiguration.Dynamics)));
        services.AddSingleton(apiGatewayOptions);

        logger.Debug("Adding memory cache");
        services.AddMemoryCache();

        // Add OAuth Middleware
        services.AddTransient<OAuthHandler>();
        // Add ApiGateway Middleware
        services.AddTransient<ApiGatewayHandler>();

        // Register IOAuthApiClient, using the token client that matches the configured
        // Dynamics authentication type (cloud Entra ID vs on-premise ADFS).
        string dynamicsApiEndpointUrl = ConfigureDynamicsAuthentication(services, dynamicsOptions, logger);

        // Cloud (EntraId) hits the Dynamics endpoint directly, the on-premise (ADFS) setup
        // routes requests through the API Gateway, so only attach the ApiGatewayHandler
        // in the on-premise case. NativeOdataResourceUrl must match this same base address,
        // since it's used to build @odata.bind values (e.g. ownerid@odata.bind) that Dynamics
        // validates against the request's ServiceRouteUri.
        string apiBaseAddress = dynamicsOptions.IsCloud ? dynamicsApiEndpointUrl : apiGatewayOptions.BasePath;

        services.AddSingleton(new DynamicsClientOptions { NativeOdataResourceUrl = apiBaseAddress });

        var dynamicsClientBuilder = services.AddHttpClient<IDynamicsClient, DynamicsClient>(client =>
        {
            client.BaseAddress = new Uri(apiBaseAddress);
            client.Timeout = TimeSpan.FromSeconds(30); // data timeout

        })
        .AddHttpMessageHandler<OAuthHandler>();

        if (!dynamicsOptions.IsCloud)
        {
            dynamicsClientBuilder.AddHttpMessageHandler<ApiGatewayHandler>();
        }

        logger.Debug("Configuing FileManager Service");
        ConfigureFileManagerService(builder, configuration?.FileManager);

        services.AddHttpContextAccessor();

        // Add services
        services.AddTransient<ITokenService, TokenService>();
        services.AddTransient<IMessageService, MessageService>();
        services.AddTransient<IAccountService, AccountService>();
        services.AddTransient<IFileService, FileService>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<ILookupService, LookupService>();
        services.AddTransient<IDocumentService, DocumentService>();
        services.AddTransient<ITaskService, TaskService>();

    }

    /// <summary>
    /// Registers the <see cref="IOAuthApiClient"/> implementation matching the configured
    /// Dynamics authentication type, and returns the Dynamics API endpoint url.
    /// </summary>
    private static string ConfigureDynamicsAuthentication(IServiceCollection services, DynamicsOptions dynamicsOptions, Serilog.ILogger logger)
    {
        if (dynamicsOptions.IsCloud)
        {
            EntraIdOptions? entraIdOptions = dynamicsOptions.EntraId;
            if (string.IsNullOrEmpty(entraIdOptions?.ResourceName) || string.IsNullOrEmpty(entraIdOptions?.DynamicsApiEndpointUrl))
            {
                const string message = $"Dynamics EntraId configuration is not set, {nameof(CsrsConfiguration.Dynamics)}:{nameof(DynamicsOptions.EntraId)} is required when {nameof(DynamicsOptions.AuthenticationType)} is '{DynamicsOptions.CloudAuthenticationType}'.";
                logger.Error(message);
                throw new ConfigurationErrorsException(message);
            }

            logger.Information("Dynamics AuthenticationType is '{AuthenticationType}', using EntraId (cloud) token client", dynamicsOptions.AuthenticationType);
            services.AddHttpClient<IOAuthApiClient, EntraIdTokenClient>(client =>
            {
                client.Timeout = TimeSpan.FromSeconds(15); // set the auth timeout
            });

            return entraIdOptions.DynamicsApiEndpointUrl;
        }
        else
        {
            AdfsOptions? adfsOptions = dynamicsOptions.ADFS;
            if (string.IsNullOrEmpty(adfsOptions?.ResourceName) || string.IsNullOrEmpty(adfsOptions?.DynamicsApiEndpointUrl))
            {
                const string message = $"Dynamics ADFS configuration is not set, {nameof(CsrsConfiguration.Dynamics)}:{nameof(DynamicsOptions.ADFS)} is required when {nameof(DynamicsOptions.AuthenticationType)} is '{DynamicsOptions.OnPremiseAuthenticationType}'.";
                logger.Error(message);
                throw new ConfigurationErrorsException(message);
            }

            logger.Information("Dynamics AuthenticationType is '{AuthenticationType}', using ADFS (on-premise) token client", dynamicsOptions.AuthenticationType);
            services.AddSingleton(adfsOptions);
            services.AddHttpClient<IOAuthApiClient, AdfsTokenClient>(client =>
            {
                client.Timeout = TimeSpan.FromSeconds(15); // set the auth timeout
            });

            return adfsOptions.DynamicsApiEndpointUrl;
        }
    }

    private static void ConfigureFileManagerService(WebApplicationBuilder builder, FileManagerConfiguration? configuration)
    {
        var logger = Log.ForContext(typeof(WebApplicationBuilderExtensions));

        if (string.IsNullOrWhiteSpace(configuration?.Address))
        {
            const string message = $"FileManager configuration is not set, {nameof(CsrsConfiguration.FileManager)}:{nameof(FileManagerConfiguration.Address)} is required.";
            logger.Error(message);
            throw new ConfigurationErrorsException(message);
        }

        string address = configuration.Address;

        // determine if we are using http or https
        ChannelCredentials credentials;

        if (configuration.Secure.HasValue && !configuration.Secure.Value)
        {
            logger.Information("Configuration explicitly set Secure=false. Using insecure channel for File Manager service.");
            // Required for Grpc.Net.Client to use h2c (unencrypted HTTP/2) on .NET 6
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            credentials = ChannelCredentials.Insecure;
        }
        else
        {
            logger.Information("Configuration Secure=true or not set. Using secure channel for File Manager service.");
            credentials = ChannelCredentials.SecureSsl;
        }

        //credentials = ChannelCredentials.SecureSsl;
        logger.Information("Using file manager service {Address}", address);
        builder.Services.AddSingleton(services =>
        {
            var channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions
            {
                Credentials = credentials,
                ServiceConfig = new ServiceConfig { LoadBalancingConfigs = { new RoundRobinConfig() } },
                ServiceProvider = services

            });

            return channel;
        });

        builder.Services.AddTransient(services =>
        {
            GrpcChannel channel = services.GetRequiredService<GrpcChannel>();
            return new Csrs.Services.FileManager.FileManager.FileManagerClient(channel);
        });
    }

    /// <summary>
    /// Gets a logger for application setup.
    /// </summary>
    private static Serilog.ILogger GetLogger()
    {
        var logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.Debug()
            .CreateLogger();

        return logger;
    }
}
