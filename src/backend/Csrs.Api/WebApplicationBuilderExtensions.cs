using Csrs.Api;
using Csrs.Api.Authentication;
using Csrs.Api.Configuration;
using Csrs.Api.Models;
using Csrs.Api.Models.Dynamics;
using Csrs.Api.Repositories;
using Csrs.Api.Services;
using Simple.OData.Client;
using System.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// Adds repository and dependant services.
    /// </summary>
    /// <param name="builder"></param>
    public static void AddServices(this WebApplicationBuilder builder)
    {
        var configuration = builder.Configuration.Get<CsrsConfiguration>();
        OAuthConfiguration? oAuthOptions = configuration?.OAuth;

        if (oAuthOptions is null || oAuthOptions.ResourceUrl is null)
        {
            throw new ConfigurationErrorsException("OAuth configuration is not set");
        }

        var services = builder.Services;

        services.AddSingleton(oAuthOptions);

        services.AddMemoryCache();

        // Add OAuth Middleware
        services.AddTransient<OAuthHandler>();

        // Register IOAuthApiClient and ODataClientSettings
        services.AddHttpClient<IOAuthApiClient, OAuthApiClient>(client =>
        {
            client.Timeout = TimeSpan.FromSeconds(15); // set the auth timeout
        });

        // Register httpClient for OdataClient with OAuthHandler
        services.AddHttpClient<ODataClientSettings>(client => 
        { 
            client.BaseAddress = new Uri(oAuthOptions.ResourceUrl);
            client.Timeout = TimeSpan.FromSeconds(15000); // data timeout
        })
        .AddHttpMessageHandler<OAuthHandler>();

        services.AddHttpClient<IOptionSetRepository, OptionSetRepository>(client => 
        {
            client.BaseAddress = new Uri(oAuthOptions.ResourceUrl);
            client.Timeout = TimeSpan.FromSeconds(15000); // options timeout
        })
        .AddHttpMessageHandler<OAuthHandler>();

        services.AddTransient<IODataClient>(provider =>
        {
            var settings = provider.GetRequiredService<ODataClientSettings>();
            settings.IgnoreUnmappedProperties = true;
            return new ODataClient(settings);
        });

        services.AddHttpContextAccessor();

        // Add services
        services.AddTransient<ITokenService, TokenService>();

        services.AddTransient<IAccountService, AccountService>();
        services.AddTransient<IFileService, FileService>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IChildService, ChildService>();

        // Add repositories
        services.AddTransient<ICourtLevelRepository, CourtLevelRepository>();
        services.AddTransient<ICourtLocationRepository, CourtLocationRepository>();

        services.AddTransient<ICsrsChildRepository, CsrsChildRepository>();
        services.AddTransient<ICsrsFeedbackRepository, CsrsFeedbackRepository>();
        services.AddTransient<ICsrsFileRepository, CsrsFileRepository>();
        services.AddTransient<ICsrsPartyRepository, CsrsPartyRepository>();

        // mappers
        services.AddTransient<IInsertOrUpdateFieldMapper<Csrs.Api.Models.File, SSG_CsrsFile>, FileInsertOrUpdateFieldMapper>();
        services.AddTransient<IInsertOrUpdateFieldMapper<Party, SSG_CsrsParty>, PartyInsertOrUpdateFieldMapper>();

    }
}
