namespace Csrs.Api.Configuration
{
    public class CsrsConfiguration
    {
        /// <summary>
        /// Contains the Splunk configuration.
        /// </summary>
        public SplunkConfiguration? Splunk { get; set; }
        
        /// <summary>
        /// Contains the OAuth configuration.
        /// </summary>
        public OAuthConfiguration? OAuth { get; set; }
    }
}
