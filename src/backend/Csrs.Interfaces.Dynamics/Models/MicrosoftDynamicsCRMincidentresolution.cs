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
    /// Microsoft.Dynamics.CRM.incidentresolution
    /// </summary>
    public partial class MicrosoftDynamicsCRMincidentresolution
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMincidentresolution class.
        /// </summary>
        public MicrosoftDynamicsCRMincidentresolution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMincidentresolution class.
        /// </summary>
        public MicrosoftDynamicsCRMincidentresolution(int? importsequencenumber = default(int?), string category = default(string), string _createdbyexternalpartyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _incidentidValue = default(string), string subcategory = default(string), string _modifiedbyexternalpartyValue = default(string), int? timespent = default(int?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailIncidentresolution = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordIncidentresolution = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLeadIncidentresolution = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingIncidentresolution = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderIncidentresolution = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationIncidentresolution = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignIncidentresolution = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityIncidentresolution = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementIncidentresolution = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateIncidentresolution = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMaccount regardingobjectidAccountIncidentresolution = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmailbox sendermailboxidIncidentresolution = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidIncidentresolution = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridIncidentresolution = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguserIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaIncidentresolution = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitIncidentresolution = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleIncidentresolution = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyIncidentresolution = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamIncidentresolution = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaIncidentresolution = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> incidentresolutionActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignResponseIncidentResolutions = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMsyncerror> incidentResolutionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> incidentResolutionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> incidentresolutionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> incidentResolutionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> incidentresolutionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> incidentResolutionAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMincident incidentid = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMservice serviceidIncidentresolution = default(MicrosoftDynamicsCRMservice))
        {
            Importsequencenumber = importsequencenumber;
            Category = category;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            Overriddencreatedon = overriddencreatedon;
            this._incidentidValue = _incidentidValue;
            Subcategory = subcategory;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            Timespent = timespent;
            RegardingobjectidNewInteractionforemailIncidentresolution = regardingobjectidNewInteractionforemailIncidentresolution;
            RegardingobjectidKnowledgebaserecordIncidentresolution = regardingobjectidKnowledgebaserecordIncidentresolution;
            RegardingobjectidLeadIncidentresolution = regardingobjectidLeadIncidentresolution;
            RegardingobjectidBookableresourcebookingIncidentresolution = regardingobjectidBookableresourcebookingIncidentresolution;
            RegardingobjectidBookableresourcebookingheaderIncidentresolution = regardingobjectidBookableresourcebookingheaderIncidentresolution;
            RegardingobjectidBulkoperationIncidentresolution = regardingobjectidBulkoperationIncidentresolution;
            RegardingobjectidCampaignIncidentresolution = regardingobjectidCampaignIncidentresolution;
            RegardingobjectidCampaignactivityIncidentresolution = regardingobjectidCampaignactivityIncidentresolution;
            RegardingobjectidEntitlementIncidentresolution = regardingobjectidEntitlementIncidentresolution;
            RegardingobjectidEntitlementtemplateIncidentresolution = regardingobjectidEntitlementtemplateIncidentresolution;
            RegardingobjectidAccountIncidentresolution = regardingobjectidAccountIncidentresolution;
            CreatedbyIncidentresolution = createdbyIncidentresolution;
            SendermailboxidIncidentresolution = sendermailboxidIncidentresolution;
            TransactioncurrencyidIncidentresolution = transactioncurrencyidIncidentresolution;
            OwneridIncidentresolution = owneridIncidentresolution;
            OwninguserIncidentresolution = owninguserIncidentresolution;
            SlaActivitypointerSlaIncidentresolution = slaActivitypointerSlaIncidentresolution;
            OwningbusinessunitIncidentresolution = owningbusinessunitIncidentresolution;
            RegardingobjectidKnowledgearticleIncidentresolution = regardingobjectidKnowledgearticleIncidentresolution;
            ModifiedonbehalfbyIncidentresolution = modifiedonbehalfbyIncidentresolution;
            CreatedonbehalfbyIncidentresolution = createdonbehalfbyIncidentresolution;
            ModifiedbyIncidentresolution = modifiedbyIncidentresolution;
            OwningteamIncidentresolution = owningteamIncidentresolution;
            SlainvokedidActivitypointerSlaIncidentresolution = slainvokedidActivitypointerSlaIncidentresolution;
            ActivityidActivitypointer = activityidActivitypointer;
            IncidentresolutionActivityParties = incidentresolutionActivityParties;
            CampaignResponseIncidentResolutions = campaignResponseIncidentResolutions;
            IncidentResolutionSyncErrors = incidentResolutionSyncErrors;
            IncidentResolutionAsyncOperations = incidentResolutionAsyncOperations;
            IncidentresolutionMailboxTrackingFolders = incidentresolutionMailboxTrackingFolders;
            IncidentResolutionBulkDeleteFailures = incidentResolutionBulkDeleteFailures;
            IncidentresolutionPrincipalObjectAttributeAccesses = incidentresolutionPrincipalObjectAttributeAccesses;
            IncidentResolutionAnnotation = incidentResolutionAnnotation;
            Incidentid = incidentid;
            ServiceidIncidentresolution = serviceidIncidentresolution;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_incidentid_value")]
        public string _incidentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timespent")]
        public int? Timespent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_incidentresolution")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_incidentresolution")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_incidentresolution")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_incidentresolution")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_incidentresolution")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_incidentresolution")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_incidentresolution")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_incidentresolution")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_incidentresolution")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_incidentresolution")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_incidentresolution")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_incidentresolution")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_incidentresolution")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_incidentresolution")]
        public MicrosoftDynamicsCRMprincipal OwneridIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser OwninguserIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_incidentresolution")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_incidentresolution")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_incidentresolution")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_incidentresolution")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_incidentresolution")]
        public MicrosoftDynamicsCRMteam OwningteamIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_incidentresolution")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaIncidentresolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> IncidentresolutionActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignResponse_IncidentResolutions")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignResponseIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> IncidentResolutionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> IncidentResolutionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> IncidentresolutionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> IncidentResolutionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentresolution_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> IncidentresolutionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentResolution_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> IncidentResolutionAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public MicrosoftDynamicsCRMincident Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_incidentresolution")]
        public MicrosoftDynamicsCRMservice ServiceidIncidentresolution { get; set; }

    }
}
