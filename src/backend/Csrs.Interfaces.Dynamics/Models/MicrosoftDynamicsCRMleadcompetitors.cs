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
    /// Microsoft.Dynamics.CRM.leadcompetitors
    /// </summary>
    public partial class MicrosoftDynamicsCRMleadcompetitors
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadcompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMleadcompetitors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMleadcompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMleadcompetitors(string leadcompetitorid = default(string), int? timezoneruleversionnumber = default(int?), int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), string competitorid = default(string), string name = default(string), string leadid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string versionnumber = default(string), IList<MicrosoftDynamicsCRMasyncoperation> leadcompetitorsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> leadcompetitorsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> leadcompetitorsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> leadcompetitorsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Leadcompetitorid = leadcompetitorid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Competitorid = competitorid;
            Name = name;
            Leadid = leadid;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            LeadcompetitorsAsyncOperations = leadcompetitorsAsyncOperations;
            LeadcompetitorsMailboxTrackingFolders = leadcompetitorsMailboxTrackingFolders;
            LeadcompetitorsBulkDeleteFailures = leadcompetitorsBulkDeleteFailures;
            LeadcompetitorsPrincipalObjectAttributeAccesses = leadcompetitorsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadcompetitorid")]
        public string Leadcompetitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadid")]
        public string Leadid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadcompetitors_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> LeadcompetitorsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadcompetitors_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> LeadcompetitorsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadcompetitors_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> LeadcompetitorsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadcompetitors_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> LeadcompetitorsPrincipalObjectAttributeAccesses { get; set; }

    }
}
