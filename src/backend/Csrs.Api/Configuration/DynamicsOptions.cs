using System.ComponentModel.DataAnnotations;

namespace Csrs.Api.Configuration
{
    /// <summary>
    /// Configuration for connecting to Dynamics. Dynamics can be hosted on-premise
    /// (authenticated via ADFS) or in the cloud (authenticated via Microsoft Entra ID).
    /// </summary>
    public class DynamicsOptions
    {
        public const string OnPremiseAuthenticationType = "OnPremise";
        public const string CloudAuthenticationType = "Cloud";

        /// <summary>
        /// Determines which authentication setup (<see cref="ADFS"/> or <see cref="EntraId"/>)
        /// should be used. Expected values are "OnPremise" or "Cloud".
        /// </summary>
        [Required]
        public string AuthenticationType { get; set; } = OnPremiseAuthenticationType;

        /// <summary>
        /// Configuration used when authenticating against an on-premise ADFS instance.
        /// </summary>
        public AdfsOptions? ADFS { get; set; }

        /// <summary>
        /// Configuration used when authenticating against Microsoft Entra ID (cloud).
        /// </summary>
        public EntraIdOptions? EntraId { get; set; }

        /// <summary>
        /// Gets a value indicating whether the cloud (Entra ID) authentication setup
        /// should be used instead of the on-premise (ADFS) setup.
        /// </summary>
        public bool IsCloud => string.Equals(AuthenticationType, CloudAuthenticationType, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Configuration for authenticating against an on-premise ADFS instance using the
    /// resource owner password credentials grant.
    /// </summary>
    public class AdfsOptions
    {
        [Required]
        public string? DynamicsApiEndpointUrl { get; set; }

        [Required]
        public string? OAuth2TokenEndpoint { get; set; }

        [Required]
        public string? ClientId { get; set; }

        [Required]
        public string? ClientSecret { get; set; }

        [Required]
        public string? ServiceAccountName { get; set; }

        [Required]
        public string? ServiceAccountPassword { get; set; }

        [Required]
        public string? ResourceName { get; set; }
    }

    /// <summary>
    /// Configuration for authenticating against Microsoft Entra ID using the client
    /// credentials grant.
    /// </summary>
    public class EntraIdOptions
    {
        [Required]
        public string? DynamicsApiEndpointUrl { get; set; }

        [Required]
        public string? TenantId { get; set; }

        [Required]
        public string? ClientId { get; set; }

        [Required]
        public string? ClientSecret { get; set; }

        [Required]
        public string? ResourceName { get; set; }
    }
}
