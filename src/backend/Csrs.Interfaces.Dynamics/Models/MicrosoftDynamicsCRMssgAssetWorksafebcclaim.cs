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
    /// Microsoft.Dynamics.CRM.ssg_asset_worksafebcclaim
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgAssetWorksafebcclaim
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetWorksafebcclaim class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetWorksafebcclaim()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetWorksafebcclaim class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetWorksafebcclaim(string ssgClaimamount = default(string), bool? ssgCpcommentupdated = default(bool?), int? statecode = default(int?), bool? ssgRespcommentupdated = default(bool?), string ssgName = default(string), string ssgResponsecomment = default(string), string versionnumber = default(string), int? importsequencenumber = default(int?), string _ssgConfirmedprofileValue = default(string), string ssgEmployername = default(string), bool? ssgAddtocp = default(bool?), string _ssgSearchrequestidValue = default(string), bool? ssgCopycpcomment = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? ssgSuppliedby = default(int?), string _owneridValue = default(string), string _ssgEmploymentValue = default(string), string _ssgNotetemplateValue = default(string), System.DateTimeOffset? ssgDatadate = default(System.DateTimeOffset?), string ssgDatadatelabel = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statuscode = default(int?), string _owningteamValue = default(string), string ssgDatadatetext = default(string), string _ssgCopycptosridValue = default(string), string _modifiedonbehalfbyValue = default(string), string _ssgBankinginformationidValue = default(string), string ssgDescription = default(string), System.DateTimeOffset? ssgAddedtocpon = default(System.DateTimeOffset?), string ssgPersonname = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string ssgDatadatelabel2 = default(string), bool? ssgAddtoresponse = default(bool?), string ssgDatadate2text = default(string), string _owninguserValue = default(string), string ssgNotes = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _ssgSearchrequestValue = default(string), int? timezoneruleversionnumber = default(int?), string ssgConfirmcomment = default(string), string ssgClaimantnumber = default(string), string ssgSuppliedbytext = default(string), string ssgAssetWorksafebcclaimid = default(string), int? ssgSuppliedbyuser = default(int?), System.DateTimeOffset? ssgPersondateofbirth = default(System.DateTimeOffset?), int? ssgDatastatus = default(int?), string ssgSearchrequesttext = default(string), string ssgAddedtocpbyuser = default(string), string _ssgPersonidValue = default(string), string _owningbusinessunitValue = default(string), string _ssgResponseidValue = default(string), string ssgSuppliertypecode = default(string), System.DateTimeOffset? ssgDatadate2 = default(System.DateTimeOffset?), string _createdbyValue = default(string), string ssgAddedtoresponseindicator = default(string), int? utcconversiontimezonecode = default(int?), string ssgOldworksafebcclaimid = default(string), bool? ssgCouldnotlocate = default(bool?), string ssgClaimstatus = default(string), string _ssgResponsedatasummaryValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgAssetWorksafebcclaimSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetWorksafebcclaimDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetWorksafebcclaimDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgAssetWorksafebcclaimAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgAssetWorksafebcclaimMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgAssetWorksafebcclaimProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgAssetWorksafebcclaimBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgAssetWorksafebcclaimPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgNotestemplates ssgNoteTemplate = default(MicrosoftDynamicsCRMssgNotestemplates), MicrosoftDynamicsCRMssgSearchrequestresponse ssgResponseId = default(MicrosoftDynamicsCRMssgSearchrequestresponse), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequestId = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgPerson ssgPersonId = default(MicrosoftDynamicsCRMssgPerson), MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold ssgCopyCpToSrId = default(MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfile = default(MicrosoftDynamicsCRMssgConfirmedprofile), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> ssgWorksafebcclaimResulttransaction = default(IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction>), MicrosoftDynamicsCRMssgEmployment ssgEmployment = default(MicrosoftDynamicsCRMssgEmployment), MicrosoftDynamicsCRMssgResponsedatasummary ssgResponseDataSummary = default(MicrosoftDynamicsCRMssgResponsedatasummary), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgAssetWorksafebcclaimSsgRequestforinformationletterTemplateEntityWorkSafeBCClaim = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>), MicrosoftDynamicsCRMssgAssetBankinginformation ssgBankingInformationId = default(MicrosoftDynamicsCRMssgAssetBankinginformation))
        {
            SsgClaimamount = ssgClaimamount;
            SsgCpcommentupdated = ssgCpcommentupdated;
            Statecode = statecode;
            SsgRespcommentupdated = ssgRespcommentupdated;
            SsgName = ssgName;
            SsgResponsecomment = ssgResponsecomment;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            this._ssgConfirmedprofileValue = _ssgConfirmedprofileValue;
            SsgEmployername = ssgEmployername;
            SsgAddtocp = ssgAddtocp;
            this._ssgSearchrequestidValue = _ssgSearchrequestidValue;
            SsgCopycpcomment = ssgCopycpcomment;
            Overriddencreatedon = overriddencreatedon;
            SsgSuppliedby = ssgSuppliedby;
            this._owneridValue = _owneridValue;
            this._ssgEmploymentValue = _ssgEmploymentValue;
            this._ssgNotetemplateValue = _ssgNotetemplateValue;
            SsgDatadate = ssgDatadate;
            SsgDatadatelabel = ssgDatadatelabel;
            Createdon = createdon;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            SsgDatadatetext = ssgDatadatetext;
            this._ssgCopycptosridValue = _ssgCopycptosridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._ssgBankinginformationidValue = _ssgBankinginformationidValue;
            SsgDescription = ssgDescription;
            SsgAddedtocpon = ssgAddedtocpon;
            SsgPersonname = ssgPersonname;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            SsgDatadatelabel2 = ssgDatadatelabel2;
            SsgAddtoresponse = ssgAddtoresponse;
            SsgDatadate2text = ssgDatadate2text;
            this._owninguserValue = _owninguserValue;
            SsgNotes = ssgNotes;
            Modifiedon = modifiedon;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgConfirmcomment = ssgConfirmcomment;
            SsgClaimantnumber = ssgClaimantnumber;
            SsgSuppliedbytext = ssgSuppliedbytext;
            SsgAssetWorksafebcclaimid = ssgAssetWorksafebcclaimid;
            SsgSuppliedbyuser = ssgSuppliedbyuser;
            SsgPersondateofbirth = ssgPersondateofbirth;
            SsgDatastatus = ssgDatastatus;
            SsgSearchrequesttext = ssgSearchrequesttext;
            SsgAddedtocpbyuser = ssgAddedtocpbyuser;
            this._ssgPersonidValue = _ssgPersonidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._ssgResponseidValue = _ssgResponseidValue;
            SsgSuppliertypecode = ssgSuppliertypecode;
            SsgDatadate2 = ssgDatadate2;
            this._createdbyValue = _createdbyValue;
            SsgAddedtoresponseindicator = ssgAddedtoresponseindicator;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SsgOldworksafebcclaimid = ssgOldworksafebcclaimid;
            SsgCouldnotlocate = ssgCouldnotlocate;
            SsgClaimstatus = ssgClaimstatus;
            this._ssgResponsedatasummaryValue = _ssgResponsedatasummaryValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgAssetWorksafebcclaimSyncErrors = ssgAssetWorksafebcclaimSyncErrors;
            SsgAssetWorksafebcclaimDuplicateMatchingRecord = ssgAssetWorksafebcclaimDuplicateMatchingRecord;
            SsgAssetWorksafebcclaimDuplicateBaseRecord = ssgAssetWorksafebcclaimDuplicateBaseRecord;
            SsgAssetWorksafebcclaimAsyncOperations = ssgAssetWorksafebcclaimAsyncOperations;
            SsgAssetWorksafebcclaimMailboxTrackingFolders = ssgAssetWorksafebcclaimMailboxTrackingFolders;
            SsgAssetWorksafebcclaimProcessSession = ssgAssetWorksafebcclaimProcessSession;
            SsgAssetWorksafebcclaimBulkDeleteFailures = ssgAssetWorksafebcclaimBulkDeleteFailures;
            SsgAssetWorksafebcclaimPrincipalObjectAttributeAccesses = ssgAssetWorksafebcclaimPrincipalObjectAttributeAccesses;
            SsgNoteTemplate = ssgNoteTemplate;
            SsgResponseId = ssgResponseId;
            SsgSearchRequestId = ssgSearchRequestId;
            SsgPersonId = ssgPersonId;
            SsgCopyCpToSrId = ssgCopyCpToSrId;
            SsgConfirmedProfile = ssgConfirmedProfile;
            SsgSearchRequest = ssgSearchRequest;
            SsgWorksafebcclaimResulttransaction = ssgWorksafebcclaimResulttransaction;
            SsgEmployment = ssgEmployment;
            SsgResponseDataSummary = ssgResponseDataSummary;
            SsgSsgAssetWorksafebcclaimSsgRequestforinformationletterTemplateEntityWorkSafeBCClaim = ssgSsgAssetWorksafebcclaimSsgRequestforinformationletterTemplateEntityWorkSafeBCClaim;
            SsgBankingInformationId = ssgBankingInformationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_claimamount")]
        public string SsgClaimamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cpcommentupdated")]
        public bool? SsgCpcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_respcommentupdated")]
        public bool? SsgRespcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsecomment")]
        public string SsgResponsecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_confirmedprofile_value")]
        public string _ssgConfirmedprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_employername")]
        public string SsgEmployername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtocp")]
        public bool? SsgAddtocp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequestid_value")]
        public string _ssgSearchrequestidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_copycpcomment")]
        public bool? SsgCopycpcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedby")]
        public int? SsgSuppliedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_employment_value")]
        public string _ssgEmploymentValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_notetemplate_value")]
        public string _ssgNotetemplateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate")]
        public System.DateTimeOffset? SsgDatadate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel")]
        public string SsgDatadatelabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatetext")]
        public string SsgDatadatetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_copycptosrid_value")]
        public string _ssgCopycptosridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_bankinginformationid_value")]
        public string _ssgBankinginformationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_description")]
        public string SsgDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpon")]
        public System.DateTimeOffset? SsgAddedtocpon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personname")]
        public string SsgPersonname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel2")]
        public string SsgDatadatelabel2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtoresponse")]
        public bool? SsgAddtoresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2text")]
        public string SsgDatadate2text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notes")]
        public string SsgNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_confirmcomment")]
        public string SsgConfirmcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_claimantnumber")]
        public string SsgClaimantnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbytext")]
        public string SsgSuppliedbytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaimid")]
        public string SsgAssetWorksafebcclaimid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyuser")]
        public int? SsgSuppliedbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persondateofbirth")]
        public System.DateTimeOffset? SsgPersondateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datastatus")]
        public int? SsgDatastatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequesttext")]
        public string SsgSearchrequesttext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpbyuser")]
        public string SsgAddedtocpbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_personid_value")]
        public string _ssgPersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responseid_value")]
        public string _ssgResponseidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliertypecode")]
        public string SsgSuppliertypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2")]
        public System.DateTimeOffset? SsgDatadate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoresponseindicator")]
        public string SsgAddedtoresponseindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_oldworksafebcclaimid")]
        public string SsgOldworksafebcclaimid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_couldnotlocate")]
        public bool? SsgCouldnotlocate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_claimstatus")]
        public string SsgClaimstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responsedatasummary_value")]
        public string _ssgResponsedatasummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgAssetWorksafebcclaimSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetWorksafebcclaimDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetWorksafebcclaimDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgAssetWorksafebcclaimAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgAssetWorksafebcclaimMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgAssetWorksafebcclaimProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgAssetWorksafebcclaimBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_worksafebcclaim_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgAssetWorksafebcclaimPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_NoteTemplate")]
        public MicrosoftDynamicsCRMssgNotestemplates SsgNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseId")]
        public MicrosoftDynamicsCRMssgSearchrequestresponse SsgResponseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequestId")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PersonId")]
        public MicrosoftDynamicsCRMssgPerson SsgPersonId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_CopyCpToSrId")]
        public MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold SsgCopyCpToSrId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfile")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_worksafebcclaim__resulttransaction")]
        public IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> SsgWorksafebcclaimResulttransaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_Employment")]
        public MicrosoftDynamicsCRMssgEmployment SsgEmployment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseDataSummary")]
        public MicrosoftDynamicsCRMssgResponsedatasummary SsgResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_asset_worksafebcclaim_ssg_requestforinformationletter_TemplateEntity_WorkSafeBCClaim")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgAssetWorksafebcclaimSsgRequestforinformationletterTemplateEntityWorkSafeBCClaim { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_BankingInformationId")]
        public MicrosoftDynamicsCRMssgAssetBankinginformation SsgBankingInformationId { get; set; }

    }
}
