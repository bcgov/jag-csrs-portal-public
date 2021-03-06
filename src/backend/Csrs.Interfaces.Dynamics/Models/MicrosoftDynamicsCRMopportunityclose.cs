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
    /// Microsoft.Dynamics.CRM.opportunityclose
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunityclose : MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityclose class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityclose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunityclose class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunityclose(System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), string _owningteamValue = default(string), string exchangeitemid = default(string), bool? ismapiprivate = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string seriesid = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? deliverylastattemptedon = default(System.DateTimeOffset?), bool? isbilled = default(bool?), bool? isworkflowcreated = default(bool?), string _sendermailboxidValue = default(string), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), string description = default(string), int? onholdtime = default(int?), string _modifiedbyValue = default(string), int? community = default(int?), System.DateTimeOffset? sortdate = default(System.DateTimeOffset?), int? instancetypecode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _transactioncurrencyidValue = default(string), string versionnumber = default(string), string processid = default(string), int? prioritycode = default(int?), string _serviceidValue = default(string), string _slaidValue = default(string), string stageid = default(string), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string exchangeweblink = default(string), int? scheduleddurationminutes = default(int?), System.DateTimeOffset? senton = default(System.DateTimeOffset?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), string _slainvokedidValue = default(string), int? statecode = default(int?), string subject = default(string), System.DateTimeOffset? postponeactivityprocessinguntil = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), decimal? exchangerate = default(decimal?), bool? isregularactivity = default(bool?), int? deliveryprioritycode = default(int?), int? actualdurationminutes = default(int?), string traversedpath = default(string), string activityid = default(string), string activitytypecode = default(string), string activityadditionalparams = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owneridValue = default(string), bool? leftvoicemail = default(bool?), int? statuscode = default(int?), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMsite regardingobjectidSite = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbum = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMssgSearchrequest regardingobjectidSsgSearchrequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgIjssservicerequest regardingobjectidSsgIjssservicerequest = default(MicrosoftDynamicsCRMssgIjssservicerequest), MicrosoftDynamicsCRMssgIjsscase regardingobjectidSsgIjsscase = default(MicrosoftDynamicsCRMssgIjsscase), MicrosoftDynamicsCRMssgCsrsfile regardingobjectidSsgCsrsfile = default(MicrosoftDynamicsCRMssgCsrsfile), MicrosoftDynamicsCRMssgCsrsrecalculation regardingobjectidSsgCsrsrecalculation = default(MicrosoftDynamicsCRMssgCsrsrecalculation), MicrosoftDynamicsCRMafkWorkflowelementoption regardingobjectidAfkWorkflowelementoption = default(MicrosoftDynamicsCRMafkWorkflowelementoption), IList<MicrosoftDynamicsCRMafkWorkflowtask> activityPointerAfkWorkflowtask = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>), MicrosoftDynamicsCRMssgRequestforinformationletter regardingobjectidSsgRequestforinformationletter = default(MicrosoftDynamicsCRMssgRequestforinformationletter), MicrosoftDynamicsCRMssgMspgroup regardingobjectidSsgMspgroup = default(MicrosoftDynamicsCRMssgMspgroup), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMrecurrencerule> activityPointerRecurrencerule = default(IList<MicrosoftDynamicsCRMrecurrencerule>), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), string _opportunityidValue = default(string), string subcategory = default(string), decimal? actualrevenue = default(decimal?), string _competitoridValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? actualrevenueBase = default(decimal?), string category = default(string), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailOpportunityclose = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordOpportunityclose = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLeadOpportunityclose = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingOpportunityclose = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderOpportunityclose = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationOpportunityclose = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignOpportunityclose = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityOpportunityclose = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementOpportunityclose = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateOpportunityclose = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncidentOpportunityclose = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsite regardingobjectidSiteOpportunityclose = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceidOpportunityclose = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityOpportunityclose = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMaccount regardingobjectidAccountOpportunityclose = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmailbox sendermailboxidOpportunityclose = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidOpportunityclose = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridOpportunityclose = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguserOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaOpportunityclose = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitOpportunityclose = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleOpportunityclose = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyOpportunityclose = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamOpportunityclose = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaOpportunityclose = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> opportunitycloseActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMcampaignresponse> campaignResponseOpportunityCloses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMsyncerror> opportunityCloseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> opportunityCloseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> opportunitycloseMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunityCloseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> opportunityclosePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> opportunityCloseAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMcompetitor competitorid = default(MicrosoftDynamicsCRMcompetitor))
            : base(lastonholdtime, _owningteamValue, exchangeitemid, ismapiprivate, createdon, seriesid, _regardingobjectidValue, deliverylastattemptedon, isbilled, isworkflowcreated, _sendermailboxidValue, scheduledend, description, onholdtime, _modifiedbyValue, community, sortdate, instancetypecode, timezoneruleversionnumber, _createdonbehalfbyValue, _createdbyValue, _transactioncurrencyidValue, versionnumber, processid, prioritycode, _serviceidValue, _slaidValue, stageid, actualstart, _owningbusinessunitValue, _owninguserValue, utcconversiontimezonecode, exchangeweblink, scheduleddurationminutes, senton, scheduledstart, _slainvokedidValue, statecode, subject, postponeactivityprocessinguntil, _modifiedonbehalfbyValue, exchangerate, isregularactivity, deliveryprioritycode, actualdurationminutes, traversedpath, activityid, activitytypecode, activityadditionalparams, modifiedon, _owneridValue, leftvoicemail, statuscode, actualend, regardingobjectidNewInteractionforemail, regardingobjectidKnowledgebaserecord, regardingobjectidLead, regardingobjectidBookableresourcebooking, regardingobjectidBookableresourcebookingheader, activityPointerBulkOperation, regardingobjectidBulkoperation, regardingobjectidCampaign, activityPointerCampaignactivity, regardingobjectidCampaignactivity, activityPointerCampaignresponse, activityPointerBulkOperationLogs, createdActivityBulkOperationLogs, activityPointerCampaignActivityItems, activityCampaignresponse, regardingobjectidContract, regardingobjectidEntitlement, regardingobjectidEntitlementtemplate, regardingobjectidIncident, activityPointerIncidentResolution, activityPointerServiceAppointment, regardingobjectidSite, serviceid, regardingobjectidInvoice, regardingobjectidOpportunity, activityPointerOpportunityClose, activityPointerOrderClose, regardingobjectidQuote, activityPointerQuoteClose, regardingobjectidSalesorder, regardingobjectidMsdynPostalbum, regardingobjectidSsgSearchrequest, regardingobjectidSsgIjssservicerequest, regardingobjectidSsgIjsscase, regardingobjectidSsgCsrsfile, regardingobjectidSsgCsrsrecalculation, regardingobjectidAfkWorkflowelementoption, activityPointerAfkWorkflowtask, regardingobjectidSsgRequestforinformationletter, regardingobjectidSsgMspgroup, regardingobjectidAccount, createdby, regardingobjectidContact, activityPointerSocialactivity, activityPointerRecurringappointmentmaster, activityPointerEmail, sendermailboxid, transactioncurrencyid, activityPointerQueueItem, ownerid, owninguser, slaActivitypointerSla, owningbusinessunit, regardingobjectidKnowledgearticle, modifiedonbehalfby, activityPointerActivityMimeAttachment, activityPointerFax, createdonbehalfby, modifiedby, activityPointerTask, activityPointerPhonecall, activityPointerAppointment, activityPointerLetter, activitypointerConnections2, slakpiinstanceActivitypointer, owningteam, activityPointerBulkDeleteFailures, slainvokedidActivitypointerSla, activitypointerConnections1, activityPointerAsyncOperations, activityPointerRecurrencerule, activitypointerActivityParties)
        {
            this._opportunityidValue = _opportunityidValue;
            Subcategory = subcategory;
            Actualrevenue = actualrevenue;
            this._competitoridValue = _competitoridValue;
            Importsequencenumber = importsequencenumber;
            Overriddencreatedon = overriddencreatedon;
            ActualrevenueBase = actualrevenueBase;
            Category = category;
            RegardingobjectidNewInteractionforemailOpportunityclose = regardingobjectidNewInteractionforemailOpportunityclose;
            RegardingobjectidKnowledgebaserecordOpportunityclose = regardingobjectidKnowledgebaserecordOpportunityclose;
            RegardingobjectidLeadOpportunityclose = regardingobjectidLeadOpportunityclose;
            RegardingobjectidBookableresourcebookingOpportunityclose = regardingobjectidBookableresourcebookingOpportunityclose;
            RegardingobjectidBookableresourcebookingheaderOpportunityclose = regardingobjectidBookableresourcebookingheaderOpportunityclose;
            RegardingobjectidBulkoperationOpportunityclose = regardingobjectidBulkoperationOpportunityclose;
            RegardingobjectidCampaignOpportunityclose = regardingobjectidCampaignOpportunityclose;
            RegardingobjectidCampaignactivityOpportunityclose = regardingobjectidCampaignactivityOpportunityclose;
            RegardingobjectidEntitlementOpportunityclose = regardingobjectidEntitlementOpportunityclose;
            RegardingobjectidEntitlementtemplateOpportunityclose = regardingobjectidEntitlementtemplateOpportunityclose;
            RegardingobjectidIncidentOpportunityclose = regardingobjectidIncidentOpportunityclose;
            RegardingobjectidSiteOpportunityclose = regardingobjectidSiteOpportunityclose;
            ServiceidOpportunityclose = serviceidOpportunityclose;
            RegardingobjectidOpportunityOpportunityclose = regardingobjectidOpportunityOpportunityclose;
            RegardingobjectidAccountOpportunityclose = regardingobjectidAccountOpportunityclose;
            CreatedbyOpportunityclose = createdbyOpportunityclose;
            SendermailboxidOpportunityclose = sendermailboxidOpportunityclose;
            TransactioncurrencyidOpportunityclose = transactioncurrencyidOpportunityclose;
            OwneridOpportunityclose = owneridOpportunityclose;
            OwninguserOpportunityclose = owninguserOpportunityclose;
            SlaActivitypointerSlaOpportunityclose = slaActivitypointerSlaOpportunityclose;
            OwningbusinessunitOpportunityclose = owningbusinessunitOpportunityclose;
            RegardingobjectidKnowledgearticleOpportunityclose = regardingobjectidKnowledgearticleOpportunityclose;
            ModifiedonbehalfbyOpportunityclose = modifiedonbehalfbyOpportunityclose;
            CreatedonbehalfbyOpportunityclose = createdonbehalfbyOpportunityclose;
            ModifiedbyOpportunityclose = modifiedbyOpportunityclose;
            OwningteamOpportunityclose = owningteamOpportunityclose;
            SlainvokedidActivitypointerSlaOpportunityclose = slainvokedidActivitypointerSlaOpportunityclose;
            ActivityidActivitypointer = activityidActivitypointer;
            OpportunitycloseActivityParties = opportunitycloseActivityParties;
            CampaignResponseOpportunityCloses = campaignResponseOpportunityCloses;
            OpportunityCloseSyncErrors = opportunityCloseSyncErrors;
            OpportunityCloseAsyncOperations = opportunityCloseAsyncOperations;
            OpportunitycloseMailboxTrackingFolders = opportunitycloseMailboxTrackingFolders;
            OpportunityCloseBulkDeleteFailures = opportunityCloseBulkDeleteFailures;
            OpportunityclosePrincipalObjectAttributeAccesses = opportunityclosePrincipalObjectAttributeAccesses;
            OpportunityCloseAnnotation = opportunityCloseAnnotation;
            Opportunityid = opportunityid;
            Competitorid = competitorid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualrevenue")]
        public decimal? Actualrevenue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_competitorid_value")]
        public string _competitoridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualrevenue_base")]
        public decimal? ActualrevenueBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_opportunityclose")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_opportunityclose")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_opportunityclose")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_opportunityclose")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_opportunityclose")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_opportunityclose")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_opportunityclose")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_opportunityclose")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_opportunityclose")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_opportunityclose")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_opportunityclose")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_opportunityclose")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_opportunityclose")]
        public MicrosoftDynamicsCRMservice ServiceidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_opportunityclose")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_opportunityclose")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_opportunityclose")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_opportunityclose")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_opportunityclose")]
        public MicrosoftDynamicsCRMprincipal OwneridOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser OwninguserOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_opportunityclose")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_opportunityclose")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_opportunityclose")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_opportunityclose")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_opportunityclose")]
        public MicrosoftDynamicsCRMteam OwningteamOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_opportunityclose")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaOpportunityclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> OpportunitycloseActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignResponse_OpportunityCloses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignResponseOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> OpportunityCloseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> OpportunityCloseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> OpportunitycloseMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunityCloseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityclose_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> OpportunityclosePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunityClose_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> OpportunityCloseAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public MicrosoftDynamicsCRMcompetitor Competitorid { get; set; }

    }
}
