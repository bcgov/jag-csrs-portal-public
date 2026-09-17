using System.Net;
using Csrs.Api.Configuration;
using Microsoft.Extensions.Options;

namespace Csrs.Api.Authentication
{
    /// <summary>
    /// The EntraIdTokenClient interacts with Microsoft Entra ID (Azure AD) using the OAuth2
    /// client-credentials grant to obtain and refresh access tokens for Dynamics Cloud.
    /// </summary>
    public class EntraIdTokenClient : IOAuthApiClient
    {
        private readonly HttpClient _httpClient;

        private readonly EntraIdOptions _entraIdOptions;

        public EntraIdTokenClient(HttpClient httpClient, IOptionsMonitor<DynamicsOptions> dynamicsOptions)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _entraIdOptions = dynamicsOptions.CurrentValue.EntraId ?? throw new ArgumentNullException(nameof(dynamicsOptions), $"{nameof(DynamicsOptions.EntraId)} configuration is not set");
        }

        public async Task<Token?> GetRefreshToken(CancellationToken cancellationToken)
        {
            if (_httpClient.DefaultRequestHeaders.Contains("Accept"))
            {
                _httpClient.DefaultRequestHeaders.Remove("Accept");
            }
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var tokenEndpoint = $"https://login.microsoftonline.com/{_entraIdOptions.TenantId}/oauth2/v2.0/token";

            var data = new Dictionary<string, string>
            {
                {"client_id", _entraIdOptions.ClientId ?? string.Empty},
                {"client_secret", _entraIdOptions.ClientSecret ?? string.Empty},
                {"scope", $"{_entraIdOptions.ResourceName}/.default"},
                {"grant_type", "client_credentials"}
            };

            var content = new FormUrlEncodedContent(data);

            using var request = new HttpRequestMessage(HttpMethod.Post, tokenEndpoint) { Content = content };

            HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                string? responseData = response.Content is null
                    ? null
                    : await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                throw new OAuthAuthorizationException(
                    $"EntraId authentication failed, the HTTP status code of the response was not expected ({(int)response.StatusCode}). {responseData}",
                    response.StatusCode);
            }

            return await response.Content.ReadFromJsonAsync<Token>(cancellationToken: cancellationToken);
        }
    }
}
