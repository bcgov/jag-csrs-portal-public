using Csrs.Api.Authentication;
using Csrs.Api.Configuration;
using Simple.OData.Client;

namespace Csrs.Api.Repositories
{
    public static class RepositoryExtensions
    {
        /// <summary>
        /// Adds repository and dependant services.
        /// </summary>
        /// <param name="builder"></param>
        public static void AddRepositories(this WebApplicationBuilder builder)
        {
            var configuration = builder.Configuration.Get<CsrsConfiguration>();
            var oAuthOptions = configuration?.OAuth;

            var services = builder.Services;

            services.AddMemoryCache();

            // Add OAuth Middleware
            services.AddTransient<OAuthHandler>();

            // Register IOAuthApiClient
            services.AddHttpClient<IOAuthApiClient, OAuthApiClient>();

            // Register httpClient for OdataClient with OAuthHandler
            services.AddHttpClient<ODataClientSettings>(cfg => { cfg.BaseAddress = new Uri(oAuthOptions.ResourceUrl); })
                .AddHttpMessageHandler<OAuthHandler>();

            services.AddTransient<IODataClient>(provider =>
            {
                var settings = provider.GetRequiredService<ODataClientSettings>();
                settings.IgnoreUnmappedProperties = true;
                return new ODataClient(settings);
            });

            // Add other Services
            services.AddTransient<ITokenService, TokenService>();

            services.AddTransient<IFileRepository, CsrsFileRepository>();
            services.AddTransient<ICsrsPartyRepository, CsrsPartyRepository>();
        }
    }
}
