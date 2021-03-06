// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.opportunitycompetitors
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunitycompetitors
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitycompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitycompetitors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitycompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitycompetitors(string opportunityid = default(string), string name = default(string), string competitorid = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), string versionnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string opportunitycompetitorid = default(string), int? importsequencenumber = default(int?), IList<MicrosoftDynamicsCRMasyncoperation> opportunitycompetitorsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> opportunitycompetitorsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunitycompetitorsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> opportunitycompetitorsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Opportunityid = opportunityid;
            Name = name;
            Competitorid = competitorid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Opportunitycompetitorid = opportunitycompetitorid;
            Importsequencenumber = importsequencenumber;
            OpportunitycompetitorsAsyncOperations = opportunitycompetitorsAsyncOperations;
            OpportunitycompetitorsMailboxTrackingFolders = opportunitycompetitorsMailboxTrackingFolders;
            OpportunitycompetitorsBulkDeleteFailures = opportunitycompetitorsBulkDeleteFailures;
            OpportunitycompetitorsPrincipalObjectAttributeAccesses = opportunitycompetitorsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public string Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitorid")]
        public string Opportunitycompetitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunitycompetitorsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> OpportunitycompetitorsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunitycompetitorsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> OpportunitycompetitorsPrincipalObjectAttributeAccesses { get; set; }

    }
}
