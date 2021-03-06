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
    /// Microsoft.Dynamics.CRM.ssg_responsedatasummary
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgResponsedatasummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgResponsedatasummary class.
        /// </summary>
        public MicrosoftDynamicsCRMssgResponsedatasummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgResponsedatasummary class.
        /// </summary>
        public MicrosoftDynamicsCRMssgResponsedatasummary(int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), System.DateTimeOffset? ssgDate1 = default(System.DateTimeOffset?), System.DateTimeOffset? ssgDate2 = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), string ssgDatasubtype = default(string), int? statuscode = default(int?), bool? ssgFlagfordeletion = default(bool?), string _modifiedbyValue = default(string), string _owneridValue = default(string), int? ssgSortorder = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ssgResponsedatasummaryid = default(string), int? utcconversiontimezonecode = default(int?), string ssgName = default(string), string ssgResponsecomment = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ssgTemplatedata = default(string), int? importsequencenumber = default(int?), int? ssgDatatype = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string versionnumber = default(string), string _ssgSearchrequestValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgResponsedatasummarySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgResponsedatasummaryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgResponsedatasummaryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgResponsedatasummaryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgResponsedatasummaryMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgResponsedatasummaryProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgResponsedatasummaryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgResponsedatasummaryPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMssgAddress> ssgSsgResponsedatasummarySsgAddressResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAddress>), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), IList<MicrosoftDynamicsCRMssgAlias> ssgSsgResponsedatasummarySsgAliasResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAlias>), IList<MicrosoftDynamicsCRMssgAssetBankinginformation> ssgSsgResponsedatasummarySsgAssetBankinginformationResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetBankinginformation>), IList<MicrosoftDynamicsCRMssgEmail> ssgSsgResponsedatasummarySsgEmailResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgEmail>), IList<MicrosoftDynamicsCRMssgEmployment> ssgSsgResponsedatasummarySsgEmploymentResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgEmployment>), IList<MicrosoftDynamicsCRMssgAssetIcbcclaim> ssgSsgResponsedatasummarySsgAssetIcbcclaimResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetIcbcclaim>), IList<MicrosoftDynamicsCRMssgIdentifier> ssgSsgResponsedatasummarySsgIdentifierResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgIdentifier>), IList<MicrosoftDynamicsCRMssgAssetInvestment> ssgSsgResponsedatasummarySsgAssetInvestmentResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetInvestment>), IList<MicrosoftDynamicsCRMssgNotes> ssgSsgResponsedatasummarySsgNotesResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgNotes>), IList<MicrosoftDynamicsCRMssgAssetOther> ssgSsgResponsedatasummarySsgAssetOtherResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetOther>), IList<MicrosoftDynamicsCRMssgAssetPensiondisability> ssgSsgResponsedatasummarySsgAssetPensiondisabilityResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetPensiondisability>), IList<MicrosoftDynamicsCRMssgPerson> ssgSsgResponsedatasummarySsgPersonResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgPerson>), IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim> ssgSsgResponsedatasummarySsgAssetWorksafebcclaimResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim>), IList<MicrosoftDynamicsCRMssgPhonenumber> ssgSsgResponsedatasummarySsgPhonenumberResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgPhonenumber>), IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> ssgSsgResponsedatasummarySsgAssetRealestatepropertyResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetRealestateproperty>), IList<MicrosoftDynamicsCRMssgIdentity> ssgSsgResponsedatasummarySsgIdentityResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgIdentity>), IList<MicrosoftDynamicsCRMssgAssetVehicle> ssgSsgResponsedatasummarySsgAssetVehicleResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgAssetVehicle>), IList<MicrosoftDynamicsCRMssgElectronicaddress> ssgSsgResponsedatasummarySsgElectronicaddressResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgElectronicaddress>), IList<MicrosoftDynamicsCRMssgSafetyconcerndetail> ssgSsgResponsedatasummarySsgSafetyconcerndetailResponseDataSummary = default(IList<MicrosoftDynamicsCRMssgSafetyconcerndetail>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            SsgDate1 = ssgDate1;
            SsgDate2 = ssgDate2;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SsgDatasubtype = ssgDatasubtype;
            Statuscode = statuscode;
            SsgFlagfordeletion = ssgFlagfordeletion;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            SsgSortorder = ssgSortorder;
            Modifiedon = modifiedon;
            SsgResponsedatasummaryid = ssgResponsedatasummaryid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SsgName = ssgName;
            SsgResponsecomment = ssgResponsecomment;
            Overriddencreatedon = overriddencreatedon;
            SsgTemplatedata = ssgTemplatedata;
            Importsequencenumber = importsequencenumber;
            SsgDatatype = ssgDatatype;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            Versionnumber = versionnumber;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgResponsedatasummarySyncErrors = ssgResponsedatasummarySyncErrors;
            SsgResponsedatasummaryDuplicateMatchingRecord = ssgResponsedatasummaryDuplicateMatchingRecord;
            SsgResponsedatasummaryDuplicateBaseRecord = ssgResponsedatasummaryDuplicateBaseRecord;
            SsgResponsedatasummaryAsyncOperations = ssgResponsedatasummaryAsyncOperations;
            SsgResponsedatasummaryMailboxTrackingFolders = ssgResponsedatasummaryMailboxTrackingFolders;
            SsgResponsedatasummaryProcessSession = ssgResponsedatasummaryProcessSession;
            SsgResponsedatasummaryBulkDeleteFailures = ssgResponsedatasummaryBulkDeleteFailures;
            SsgResponsedatasummaryPrincipalObjectAttributeAccesses = ssgResponsedatasummaryPrincipalObjectAttributeAccesses;
            SsgSsgResponsedatasummarySsgAddressResponseDataSummary = ssgSsgResponsedatasummarySsgAddressResponseDataSummary;
            SsgSearchRequest = ssgSearchRequest;
            SsgSsgResponsedatasummarySsgAliasResponseDataSummary = ssgSsgResponsedatasummarySsgAliasResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetBankinginformationResponseDataSummary = ssgSsgResponsedatasummarySsgAssetBankinginformationResponseDataSummary;
            SsgSsgResponsedatasummarySsgEmailResponseDataSummary = ssgSsgResponsedatasummarySsgEmailResponseDataSummary;
            SsgSsgResponsedatasummarySsgEmploymentResponseDataSummary = ssgSsgResponsedatasummarySsgEmploymentResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetIcbcclaimResponseDataSummary = ssgSsgResponsedatasummarySsgAssetIcbcclaimResponseDataSummary;
            SsgSsgResponsedatasummarySsgIdentifierResponseDataSummary = ssgSsgResponsedatasummarySsgIdentifierResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetInvestmentResponseDataSummary = ssgSsgResponsedatasummarySsgAssetInvestmentResponseDataSummary;
            SsgSsgResponsedatasummarySsgNotesResponseDataSummary = ssgSsgResponsedatasummarySsgNotesResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetOtherResponseDataSummary = ssgSsgResponsedatasummarySsgAssetOtherResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetPensiondisabilityResponseDataSummary = ssgSsgResponsedatasummarySsgAssetPensiondisabilityResponseDataSummary;
            SsgSsgResponsedatasummarySsgPersonResponseDataSummary = ssgSsgResponsedatasummarySsgPersonResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetWorksafebcclaimResponseDataSummary = ssgSsgResponsedatasummarySsgAssetWorksafebcclaimResponseDataSummary;
            SsgSsgResponsedatasummarySsgPhonenumberResponseDataSummary = ssgSsgResponsedatasummarySsgPhonenumberResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetRealestatepropertyResponseDataSummary = ssgSsgResponsedatasummarySsgAssetRealestatepropertyResponseDataSummary;
            SsgSsgResponsedatasummarySsgIdentityResponseDataSummary = ssgSsgResponsedatasummarySsgIdentityResponseDataSummary;
            SsgSsgResponsedatasummarySsgAssetVehicleResponseDataSummary = ssgSsgResponsedatasummarySsgAssetVehicleResponseDataSummary;
            SsgSsgResponsedatasummarySsgElectronicaddressResponseDataSummary = ssgSsgResponsedatasummarySsgElectronicaddressResponseDataSummary;
            SsgSsgResponsedatasummarySsgSafetyconcerndetailResponseDataSummary = ssgSsgResponsedatasummarySsgSafetyconcerndetailResponseDataSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_date1")]
        public System.DateTimeOffset? SsgDate1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_date2")]
        public System.DateTimeOffset? SsgDate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datasubtype")]
        public string SsgDatasubtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_flagfordeletion")]
        public bool? SsgFlagfordeletion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_sortorder")]
        public int? SsgSortorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummaryid")]
        public string SsgResponsedatasummaryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_templatedata")]
        public string SsgTemplatedata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datatype")]
        public int? SsgDatatype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequest_value")]
        public string _ssgSearchrequestValue { get; set; }

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
        [JsonProperty(PropertyName = "ssg_responsedatasummary_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgResponsedatasummarySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgResponsedatasummaryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgResponsedatasummaryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgResponsedatasummaryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgResponsedatasummaryMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgResponsedatasummaryProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgResponsedatasummaryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsedatasummary_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgResponsedatasummaryPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_address_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAddress> SsgSsgResponsedatasummarySsgAddressResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_alias_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAlias> SsgSsgResponsedatasummarySsgAliasResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_bankinginformation_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetBankinginformation> SsgSsgResponsedatasummarySsgAssetBankinginformationResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_email_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgEmail> SsgSsgResponsedatasummarySsgEmailResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_employment_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgEmployment> SsgSsgResponsedatasummarySsgEmploymentResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_icbcclaim_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetIcbcclaim> SsgSsgResponsedatasummarySsgAssetIcbcclaimResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_identifier_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgIdentifier> SsgSsgResponsedatasummarySsgIdentifierResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_investment_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetInvestment> SsgSsgResponsedatasummarySsgAssetInvestmentResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_notes_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgNotes> SsgSsgResponsedatasummarySsgNotesResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_other_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetOther> SsgSsgResponsedatasummarySsgAssetOtherResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_pensiondisability_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetPensiondisability> SsgSsgResponsedatasummarySsgAssetPensiondisabilityResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_person_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgPerson> SsgSsgResponsedatasummarySsgPersonResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_worksafebcclaim_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim> SsgSsgResponsedatasummarySsgAssetWorksafebcclaimResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_phonenumber_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgPhonenumber> SsgSsgResponsedatasummarySsgPhonenumberResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_realestateproperty_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> SsgSsgResponsedatasummarySsgAssetRealestatepropertyResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_identity_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgIdentity> SsgSsgResponsedatasummarySsgIdentityResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_asset_vehicle_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgAssetVehicle> SsgSsgResponsedatasummarySsgAssetVehicleResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_electronicaddress_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgElectronicaddress> SsgSsgResponsedatasummarySsgElectronicaddressResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_responsedatasummary_ssg_safetyconcerndetail_ResponseDataSummary")]
        public IList<MicrosoftDynamicsCRMssgSafetyconcerndetail> SsgSsgResponsedatasummarySsgSafetyconcerndetailResponseDataSummary { get; set; }

    }
}
