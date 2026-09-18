using Csrs.Api.Configuration;
using System.Net;

namespace Csrs.Api.Authentication
{
    /// <summary>
    /// The AdfsTokenClient interacts with an on-premise ADFS OAuth2 token endpoint,
    /// using the resource owner password credentials grant, to obtain access tokens.
    /// </summary>
    public class AdfsTokenClient : IOAuthApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly AdfsOptions _options;
        private readonly ILogger<AdfsTokenClient> _logger;

        public AdfsTokenClient(HttpClient httpClient, AdfsOptions options, ILogger<AdfsTokenClient> logger)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Token?> GetRefreshToken(CancellationToken cancellationToken)
        {
            Dictionary<string, string> data = new()
            {
                {"resource", _options.ResourceName ?? string.Empty},
                {"client_id", _options.ClientId ?? string.Empty },
                {"client_secret", _options.ClientSecret ?? string.Empty },
                {"username", _options.ServiceAccountName ?? string.Empty },
                {"password", _options.ServiceAccountPassword ?? string.Empty },
                {"scope", "openid"},
                {"response_mode", "form_post"},
                {"grant_type", "password"}
            };

            var content = new FormUrlEncodedContent(data);

            using var request = new HttpRequestMessage(HttpMethod.Post, _options.OAuth2TokenEndpoint) { Content = content };
            request.Headers.Add("client-request-id", Guid.NewGuid().ToString());
            request.Headers.Add("return-client-request-id", "true");
            request.Headers.Add("Accept", "application/json");

            HttpResponseMessage? response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                await ProcessTokenErrorAsync(response, cancellationToken);
                return null; // wont get, here ProcessTokenErrorAsync will throw OAuthAuthorizationException
            }

            if (response.Content is not null)
            {
                Token? token = await response.Content.ReadFromJsonAsync<Token>(cancellationToken: cancellationToken);
                if (token is null)
                {
                    _logger.LogWarning("ADFS authentication failed, response did not contained expected token format");
                }
                return token;
            }

            return null; // will this happen?
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="OAuthAuthorizationException"></exception>
        private async Task ProcessTokenErrorAsync(HttpResponseMessage response, CancellationToken cancellationToken)
        {
            // common errors:
            //  - 400 client id wrong            : {"error":"invalid_client","error_description":"MSIS9607: The \u0027client_id\u0027 parameter in the request is invalid. No registered client is found with this identifier."}
            //  - 400 client secret wrong        : {"error":"invalid_client","error_description":"MSIS9622: Client authentication failed. Please verify the credential provided for client authentication is valid."}
            //  - 400 username or password wrong : {"error":"invalid_grant","error_description":"MSIS9659: Invalid \u0027username\u0027 or \u0027password\u0027."}
            //  - 400 resource url is wrong      : {"error":"invalid_resource","error_description":"MSIS9602: The received \u0027resource\u0027 parameter is invalid. The authorization server can not find a registered resource with the specified identifier."}
            //  - 404 : empty

            // ensure the http status code is logged on any of the messages below
            using var statusCodeScope = _logger.Add(response.StatusCode);

            if (response.StatusCode is HttpStatusCode.BadRequest)
            {
                var error = await response.Content.ReadFromJsonAsync<OAuthError>(cancellationToken: cancellationToken);
                if (error is null)
                {
                    // this really shouldn't happen, but better than having to deal will null error lower down
                    _logger.LogError("ADFS authentication failed, response did not contained expected error format");
                }
                else
                {
                    string message = error.Code switch
                    {
                        "invalid_client" => "ADFS authentication failed, invalid client credentials",
                        "invalid_grant" => "ADFS authentication failed, invalid username or password",
                        "invalid_resource" => "ADFS authentication failed, invalid resource url",
                        _ => $"ADFS authentication failed, other error code: {error.Code}"
                    };

                    if (error.Description is not null)
                    {
                        using var _ = _logger.BeginScope(new Dictionary<string, object> { { "ErrorMessage", error.Description } });
                        _logger.LogError(message);
                    }
                    else
                    {
                        _logger.LogError(message);
                    }

                    throw new OAuthAuthorizationException(message, response.StatusCode);
                }
            }
            else if (response.StatusCode is HttpStatusCode.NotFound)
            {
                using var _ = _logger.BeginScope(new Dictionary<string, object> { { "AuthorizationUrl", _options.OAuth2TokenEndpoint ?? string.Empty } });
                _logger.LogError("ADFS authentication failed, error with authorization url");
                throw new OAuthAuthorizationException("ADFS authentication failed, error with authorization url", response.StatusCode);
            }
            else
            {
                // 500?
                _logger.LogError("ADFS authentication failed, other status code");
                throw new OAuthAuthorizationException("ADFS authentication failed, other status code", response.StatusCode);
            }
        }
    }
}
