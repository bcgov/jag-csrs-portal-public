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
    /// Microsoft.Dynamics.CRM.ssg_asset_pensiondisability
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgAssetPensiondisability
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetPensiondisability class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetPensiondisability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAssetPensiondisability class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAssetPensiondisability(string ssgConfirmcomment = default(string), string ssgNotes = default(string), string _owningteamValue = default(string), bool? ssgAddtoresponse = default(bool?), string ssgDatadatelabel2 = default(string), System.DateTimeOffset? ssgPersondateofbirth = default(System.DateTimeOffset?), string _ssgProvidercountryValue = default(string), string ssgFiletext = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? ssgDatadate2 = default(System.DateTimeOffset?), string ssgProvideraddress = default(string), string versionnumber = default(string), string _owneridValue = default(string), string ssgResponsecomment = default(string), string ssgDatadate2text = default(string), string ssgProviderphone = default(string), string ssgDatadatetext = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ssgSuppliedbytext = default(string), string _owningbusinessunitValue = default(string), bool? ssgCopycpcomment = default(bool?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? ssgDatadate = default(System.DateTimeOffset?), string ssgPersonname = default(string), int? ssgDatastatus = default(int?), string _ssgConfirmedprofileValue = default(string), string _modifiedbyValue = default(string), string ssgProvideraddressline1 = default(string), string ssgAssetPensiondisabilityid = default(string), int? statecode = default(int?), bool? ssgCpcommentupdated = default(bool?), string ssgAddedtoresponseindicator = default(string), int? statuscode = default(int?), string _owninguserValue = default(string), string ssgSuppliertypecode = default(string), decimal? exchangerate = default(decimal?), string ssgBalanceamounttext = default(string), string ssgName = default(string), string _createdbyValue = default(string), string _ssgNotetemplateValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _ssgResponseidValue = default(string), string ssgProvidercity = default(string), System.DateTimeOffset? ssgAddedtocpon = default(System.DateTimeOffset?), string _ssgProviderprovincestateValue = default(string), string ssgDescription = default(string), int? ssgSuppliedby = default(int?), string _ssgSearchrequestValue = default(string), bool? ssgCouldnotlocate = default(bool?), string ssgAddedroconfirmedprofileby = default(string), int? ssgSuppliedbyuser = default(int?), string _modifiedonbehalfbyValue = default(string), bool? ssgRespcommentupdated = default(bool?), string ssgProvideraddressline2 = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _ssgResponsedatasummaryValue = default(string), string _ssgPersonidValue = default(string), bool? ssgAddtocp = default(bool?), int? importsequencenumber = default(int?), string _createdonbehalfbyValue = default(string), string _ssgCopycptosridValue = default(string), string ssgProviderpostalcode = default(string), string ssgDatadatelabel = default(string), string ssgProvideraddressline3 = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgAssetPensiondisabilitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetPensiondisabilityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAssetPensiondisabilityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgAssetPensiondisabilityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgAssetPensiondisabilityMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgAssetPensiondisabilityProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgAssetPensiondisabilityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgAssetPensiondisabilityPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfile = default(MicrosoftDynamicsCRMssgConfirmedprofile), MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold ssgCopyCpToSrId = default(MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold), MicrosoftDynamicsCRMssgNotestemplates ssgNoteTemplate = default(MicrosoftDynamicsCRMssgNotestemplates), MicrosoftDynamicsCRMssgPerson ssgPersonId = default(MicrosoftDynamicsCRMssgPerson), MicrosoftDynamicsCRMssgSearchrequestresponse ssgResponseId = default(MicrosoftDynamicsCRMssgSearchrequestresponse), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgCountry ssgProviderCountry = default(MicrosoftDynamicsCRMssgCountry), MicrosoftDynamicsCRMssgCountrysubdivision ssgProviderProvinceState = default(MicrosoftDynamicsCRMssgCountrysubdivision), IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> ssgPensiondisabilityResulttransaction = default(IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction>), MicrosoftDynamicsCRMssgResponsedatasummary ssgResponseDataSummary = default(MicrosoftDynamicsCRMssgResponsedatasummary), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgAssetPensiondisabilitySsgRequestforinformationletterTemplateEntityPensionDisability = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>))
        {
            SsgConfirmcomment = ssgConfirmcomment;
            SsgNotes = ssgNotes;
            this._owningteamValue = _owningteamValue;
            SsgAddtoresponse = ssgAddtoresponse;
            SsgDatadatelabel2 = ssgDatadatelabel2;
            SsgPersondateofbirth = ssgPersondateofbirth;
            this._ssgProvidercountryValue = _ssgProvidercountryValue;
            SsgFiletext = ssgFiletext;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            SsgDatadate2 = ssgDatadate2;
            SsgProvideraddress = ssgProvideraddress;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            SsgResponsecomment = ssgResponsecomment;
            SsgDatadate2text = ssgDatadate2text;
            SsgProviderphone = ssgProviderphone;
            SsgDatadatetext = ssgDatadatetext;
            Modifiedon = modifiedon;
            SsgSuppliedbytext = ssgSuppliedbytext;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SsgCopycpcomment = ssgCopycpcomment;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SsgDatadate = ssgDatadate;
            SsgPersonname = ssgPersonname;
            SsgDatastatus = ssgDatastatus;
            this._ssgConfirmedprofileValue = _ssgConfirmedprofileValue;
            this._modifiedbyValue = _modifiedbyValue;
            SsgProvideraddressline1 = ssgProvideraddressline1;
            SsgAssetPensiondisabilityid = ssgAssetPensiondisabilityid;
            Statecode = statecode;
            SsgCpcommentupdated = ssgCpcommentupdated;
            SsgAddedtoresponseindicator = ssgAddedtoresponseindicator;
            Statuscode = statuscode;
            this._owninguserValue = _owninguserValue;
            SsgSuppliertypecode = ssgSuppliertypecode;
            Exchangerate = exchangerate;
            SsgBalanceamounttext = ssgBalanceamounttext;
            SsgName = ssgName;
            this._createdbyValue = _createdbyValue;
            this._ssgNotetemplateValue = _ssgNotetemplateValue;
            Overriddencreatedon = overriddencreatedon;
            this._ssgResponseidValue = _ssgResponseidValue;
            SsgProvidercity = ssgProvidercity;
            SsgAddedtocpon = ssgAddedtocpon;
            this._ssgProviderprovincestateValue = _ssgProviderprovincestateValue;
            SsgDescription = ssgDescription;
            SsgSuppliedby = ssgSuppliedby;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            SsgCouldnotlocate = ssgCouldnotlocate;
            SsgAddedroconfirmedprofileby = ssgAddedroconfirmedprofileby;
            SsgSuppliedbyuser = ssgSuppliedbyuser;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgRespcommentupdated = ssgRespcommentupdated;
            SsgProvideraddressline2 = ssgProvideraddressline2;
            Createdon = createdon;
            this._ssgResponsedatasummaryValue = _ssgResponsedatasummaryValue;
            this._ssgPersonidValue = _ssgPersonidValue;
            SsgAddtocp = ssgAddtocp;
            Importsequencenumber = importsequencenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._ssgCopycptosridValue = _ssgCopycptosridValue;
            SsgProviderpostalcode = ssgProviderpostalcode;
            SsgDatadatelabel = ssgDatadatelabel;
            SsgProvideraddressline3 = ssgProvideraddressline3;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgAssetPensiondisabilitySyncErrors = ssgAssetPensiondisabilitySyncErrors;
            SsgAssetPensiondisabilityDuplicateMatchingRecord = ssgAssetPensiondisabilityDuplicateMatchingRecord;
            SsgAssetPensiondisabilityDuplicateBaseRecord = ssgAssetPensiondisabilityDuplicateBaseRecord;
            SsgAssetPensiondisabilityAsyncOperations = ssgAssetPensiondisabilityAsyncOperations;
            SsgAssetPensiondisabilityMailboxTrackingFolders = ssgAssetPensiondisabilityMailboxTrackingFolders;
            SsgAssetPensiondisabilityProcessSession = ssgAssetPensiondisabilityProcessSession;
            SsgAssetPensiondisabilityBulkDeleteFailures = ssgAssetPensiondisabilityBulkDeleteFailures;
            SsgAssetPensiondisabilityPrincipalObjectAttributeAccesses = ssgAssetPensiondisabilityPrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            SsgConfirmedProfile = ssgConfirmedProfile;
            SsgCopyCpToSrId = ssgCopyCpToSrId;
            SsgNoteTemplate = ssgNoteTemplate;
            SsgPersonId = ssgPersonId;
            SsgResponseId = ssgResponseId;
            SsgSearchRequest = ssgSearchRequest;
            SsgProviderCountry = ssgProviderCountry;
            SsgProviderProvinceState = ssgProviderProvinceState;
            SsgPensiondisabilityResulttransaction = ssgPensiondisabilityResulttransaction;
            SsgResponseDataSummary = ssgResponseDataSummary;
            SsgSsgAssetPensiondisabilitySsgRequestforinformationletterTemplateEntityPensionDisability = ssgSsgAssetPensiondisabilitySsgRequestforinformationletterTemplateEntityPensionDisability;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_confirmcomment")]
        public string SsgConfirmcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notes")]
        public string SsgNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtoresponse")]
        public bool? SsgAddtoresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel2")]
        public string SsgDatadatelabel2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persondateofbirth")]
        public System.DateTimeOffset? SsgPersondateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_providercountry_value")]
        public string _ssgProvidercountryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_filetext")]
        public string SsgFiletext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2")]
        public System.DateTimeOffset? SsgDatadate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_provideraddress")]
        public string SsgProvideraddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsecomment")]
        public string SsgResponsecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2text")]
        public string SsgDatadate2text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_providerphone")]
        public string SsgProviderphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatetext")]
        public string SsgDatadatetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbytext")]
        public string SsgSuppliedbytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_copycpcomment")]
        public bool? SsgCopycpcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate")]
        public System.DateTimeOffset? SsgDatadate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personname")]
        public string SsgPersonname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datastatus")]
        public int? SsgDatastatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_confirmedprofile_value")]
        public string _ssgConfirmedprofileValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_provideraddressline1")]
        public string SsgProvideraddressline1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisabilityid")]
        public string SsgAssetPensiondisabilityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cpcommentupdated")]
        public bool? SsgCpcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoresponseindicator")]
        public string SsgAddedtoresponseindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliertypecode")]
        public string SsgSuppliertypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_balanceamounttext")]
        public string SsgBalanceamounttext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_notetemplate_value")]
        public string _ssgNotetemplateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responseid_value")]
        public string _ssgResponseidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_providercity")]
        public string SsgProvidercity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpon")]
        public System.DateTimeOffset? SsgAddedtocpon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_providerprovincestate_value")]
        public string _ssgProviderprovincestateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_description")]
        public string SsgDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedby")]
        public int? SsgSuppliedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_couldnotlocate")]
        public bool? SsgCouldnotlocate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedroconfirmedprofileby")]
        public string SsgAddedroconfirmedprofileby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyuser")]
        public int? SsgSuppliedbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_respcommentupdated")]
        public bool? SsgRespcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_provideraddressline2")]
        public string SsgProvideraddressline2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responsedatasummary_value")]
        public string _ssgResponsedatasummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_personid_value")]
        public string _ssgPersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtocp")]
        public bool? SsgAddtocp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_copycptosrid_value")]
        public string _ssgCopycptosridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_providerpostalcode")]
        public string SsgProviderpostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel")]
        public string SsgDatadatelabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_provideraddressline3")]
        public string SsgProvideraddressline3 { get; set; }

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
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgAssetPensiondisabilitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetPensiondisabilityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAssetPensiondisabilityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgAssetPensiondisabilityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgAssetPensiondisabilityMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgAssetPensiondisabilityProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgAssetPensiondisabilityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_asset_pensiondisability_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgAssetPensiondisabilityPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfile")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_CopyCpToSrId")]
        public MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold SsgCopyCpToSrId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_NoteTemplate")]
        public MicrosoftDynamicsCRMssgNotestemplates SsgNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_PersonId")]
        public MicrosoftDynamicsCRMssgPerson SsgPersonId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseId")]
        public MicrosoftDynamicsCRMssgSearchrequestresponse SsgResponseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ProviderCountry")]
        public MicrosoftDynamicsCRMssgCountry SsgProviderCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ProviderProvinceState")]
        public MicrosoftDynamicsCRMssgCountrysubdivision SsgProviderProvinceState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_pensiondisability___resulttransaction")]
        public IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> SsgPensiondisabilityResulttransaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseDataSummary")]
        public MicrosoftDynamicsCRMssgResponsedatasummary SsgResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_asset_pensiondisability_ssg_requestforinformationletter_TemplateEntity_PensionDisability")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgAssetPensiondisabilitySsgRequestforinformationletterTemplateEntityPensionDisability { get; set; }

    }
}
