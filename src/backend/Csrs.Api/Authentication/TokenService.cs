using Csrs.Api.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace Csrs.Api.Authentication
{
    [Serializable]
    public class OAuthApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        public OAuthApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
        }
    }

    public interface IOAuthApiClient
    {
        Task<Token> GetRefreshToken(CancellationToken cancellationToken);
    }

    /// <summary>
    /// The OAuthApiClient interact with OAuth endpoing to manage refresh tokens.
    /// </summary>
    public class OAuthApiClient : IOAuthApiClient
    {
        private readonly HttpClient _httpClient;

        private readonly OAuthConfiguration _configuration;

        public OAuthApiClient(HttpClient httpClient, OAuthConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Token> GetRefreshToken(CancellationToken cancellationToken)
        {
            Dictionary<string, string> data = new()
            {
                {"resource", _configuration.ResourceUrl},
                {"client_id", _configuration.ClientId},
                {"client_secret", _configuration.Secret},
                {"username", _configuration.Username},
                {"password", _configuration.Password},
                {"scope", "openid"},
                {"response_mode", "form_post"},
                {"grant_type", "password"}
            };

            var content = new FormUrlEncodedContent(data);

            using (var request = new HttpRequestMessage(HttpMethod.Post, _configuration.OAuthUrl) { Content = content })
            {
                request.Headers.Add("client-request-id", Guid.NewGuid().ToString());
                request.Headers.Add("return-client-request-id", "true");
                request.Headers.Add("Accept", "application/json");

                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    var responseData = response.Content == null
                        ? null
                        : await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    throw new OAuthApiException(
                        "The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").",
                        (int)response.StatusCode, responseData,
                        response.Headers.ToDictionary(x => x.Key, x => x.Value), null);
                }

                Token token = await response.Content.ReadFromJsonAsync<Token>();
                return token;
            }
        }
    }

    public interface ITokenService
    {
        Task<Token> GetTokenAsync(CancellationToken cancellationToken);
    }

    /// <summary>
    /// The TokenService expose services to get OAuth Tokens
    /// </summary>
    public class TokenService : ITokenService
    {
        private const int Buffer = 60;

        private const string token_key = "oauth-token";

        private readonly IOAuthApiClient _oAuthApiClient;
        private readonly IMemoryCache _cache;

        public TokenService(IOAuthApiClient oAuthApiClient, IMemoryCache cache)
        {
            _oAuthApiClient = oAuthApiClient ?? throw new ArgumentNullException(nameof(oAuthApiClient));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }

        /// <summary>
        /// Gets a token, from the cache or the authority provider.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Token> GetTokenAsync(CancellationToken cancellationToken)
        {
            return await GetOrRefreshTokenAsync(cancellationToken);
        }

        private async Task<Token> GetOrRefreshTokenAsync(CancellationToken cancellationToken)
        {
            var token = _cache.Get<Token>(token_key);
            if (token == null)
            {
                token = await RefreshTokenAsync(cancellationToken);
            }

            return token;
        }

        private async Task<Token> RefreshTokenAsync(CancellationToken cancellationToken)
        {
            var token = await _oAuthApiClient.GetRefreshToken(cancellationToken);
            var options = new MemoryCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(token.ExpiresIn - Buffer) };
            _cache.Set(token_key, token, options);
            return token;
        }
    }
}
