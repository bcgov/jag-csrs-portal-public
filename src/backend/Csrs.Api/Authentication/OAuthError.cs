using System.Text.Json.Serialization;

namespace Csrs.Api.Authentication
{
    public class OAuthError
    {
        [JsonPropertyName("error")]
        public string? Code { get; set; }
        [JsonPropertyName("error_description")]
        public string? Description { get; set; }
    }
}
