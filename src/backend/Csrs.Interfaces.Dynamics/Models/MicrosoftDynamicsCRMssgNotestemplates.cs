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
    /// Microsoft.Dynamics.CRM.ssg_notestemplates
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgNotestemplates
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgNotestemplates class.
        /// </summary>
        public MicrosoftDynamicsCRMssgNotestemplates()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgNotestemplates class.
        /// </summary>
        public MicrosoftDynamicsCRMssgNotestemplates(string versionnumber = default(string), string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ssgName = default(string), string _modifiedonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ssgDescription = default(string), int? statecode = default(int?), int? ssgType = default(int?), int? utcconversiontimezonecode = default(int?), string _owningteamValue = default(string), string ssgNotestemplatesid = default(string), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), string ssgTypetext = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgNotestemplatesSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgNotestemplatesDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgNotestemplatesDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgNotestemplatesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgNotestemplatesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgNotestemplatesProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgNotestemplatesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgNotestemplatesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMssgAddress> ssgSsgNotestemplatesSsgAddressNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAddress>), IList<MicrosoftDynamicsCRMssgIdentifier> ssgSsgNotestemplatesSsgIdentifierNoteTemplate = default(IList<MicrosoftDynamicsCRMssgIdentifier>), IList<MicrosoftDynamicsCRMssgAlias> ssgSsgNotestemplatesSsgAliasNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAlias>), IList<MicrosoftDynamicsCRMssgPhonenumber> ssgSsgNotestemplatesSsgPhonenumberNoteTemplate = default(IList<MicrosoftDynamicsCRMssgPhonenumber>), IList<MicrosoftDynamicsCRMssgEmail> ssgSsgNotestemplatesSsgEmailNoteTemplate = default(IList<MicrosoftDynamicsCRMssgEmail>), IList<MicrosoftDynamicsCRMssgElectronicaddress> ssgSsgNotestemplatesSsgElectronicaddressNoteTemplate = default(IList<MicrosoftDynamicsCRMssgElectronicaddress>), IList<MicrosoftDynamicsCRMssgEmployment> ssgSsgNotestemplatesSsgEmploymentNoteTemplate = default(IList<MicrosoftDynamicsCRMssgEmployment>), IList<MicrosoftDynamicsCRMssgIdentity> ssgSsgNotestemplatesSsgIdentityNoteTemplate = default(IList<MicrosoftDynamicsCRMssgIdentity>), IList<MicrosoftDynamicsCRMssgPerson> ssgSsgNotestemplatesSsgPersonNotesTemplate = default(IList<MicrosoftDynamicsCRMssgPerson>), IList<MicrosoftDynamicsCRMssgNotes> ssgSsgNotestemplatesSsgNotesNoteTemplate = default(IList<MicrosoftDynamicsCRMssgNotes>), IList<MicrosoftDynamicsCRMssgAssetVehicle> ssgSsgNotestemplatesSsgAssetVehicleNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetVehicle>), IList<MicrosoftDynamicsCRMssgAssetIcbcclaim> ssgSsgNotestemplatesSsgAssetIcbcclaimNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetIcbcclaim>), IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim> ssgSsgNotestemplatesSsgAssetWorksafebcclaimNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim>), IList<MicrosoftDynamicsCRMssgAssetInvestment> ssgSsgNotestemplatesSsgAssetInvestmentNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetInvestment>), IList<MicrosoftDynamicsCRMssgAssetBankinginformation> ssgNotestemplatesSsgAssetBankinginformationNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetBankinginformation>), IList<MicrosoftDynamicsCRMssgAssetOther> ssgNotestemplatesSsgAssetOtherNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetOther>), IList<MicrosoftDynamicsCRMssgAssetPensiondisability> ssgSsgNotestemplatesSsgAssetPensiondisabilityNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetPensiondisability>), IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> ssgSsgNotestemplatesSsgAssetRealestatepropertyNoteTemplate = default(IList<MicrosoftDynamicsCRMssgAssetRealestateproperty>), IList<MicrosoftDynamicsCRMssgSafetyconcerndetail> ssgSsgNotestemplatesSsgSafetyconcerndetailNoteTemplate = default(IList<MicrosoftDynamicsCRMssgSafetyconcerndetail>), IList<MicrosoftDynamicsCRMssgAgency> ssgSsgNotestemplatesSsgAgencyDefaultresponsenote = default(IList<MicrosoftDynamicsCRMssgAgency>))
        {
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            SsgName = ssgName;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statuscode = statuscode;
            Modifiedon = modifiedon;
            SsgDescription = ssgDescription;
            Statecode = statecode;
            SsgType = ssgType;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningteamValue = _owningteamValue;
            SsgNotestemplatesid = ssgNotestemplatesid;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            SsgTypetext = ssgTypetext;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgNotestemplatesSyncErrors = ssgNotestemplatesSyncErrors;
            SsgNotestemplatesDuplicateMatchingRecord = ssgNotestemplatesDuplicateMatchingRecord;
            SsgNotestemplatesDuplicateBaseRecord = ssgNotestemplatesDuplicateBaseRecord;
            SsgNotestemplatesAsyncOperations = ssgNotestemplatesAsyncOperations;
            SsgNotestemplatesMailboxTrackingFolders = ssgNotestemplatesMailboxTrackingFolders;
            SsgNotestemplatesProcessSession = ssgNotestemplatesProcessSession;
            SsgNotestemplatesBulkDeleteFailures = ssgNotestemplatesBulkDeleteFailures;
            SsgNotestemplatesPrincipalObjectAttributeAccesses = ssgNotestemplatesPrincipalObjectAttributeAccesses;
            SsgSsgNotestemplatesSsgAddressNoteTemplate = ssgSsgNotestemplatesSsgAddressNoteTemplate;
            SsgSsgNotestemplatesSsgIdentifierNoteTemplate = ssgSsgNotestemplatesSsgIdentifierNoteTemplate;
            SsgSsgNotestemplatesSsgAliasNoteTemplate = ssgSsgNotestemplatesSsgAliasNoteTemplate;
            SsgSsgNotestemplatesSsgPhonenumberNoteTemplate = ssgSsgNotestemplatesSsgPhonenumberNoteTemplate;
            SsgSsgNotestemplatesSsgEmailNoteTemplate = ssgSsgNotestemplatesSsgEmailNoteTemplate;
            SsgSsgNotestemplatesSsgElectronicaddressNoteTemplate = ssgSsgNotestemplatesSsgElectronicaddressNoteTemplate;
            SsgSsgNotestemplatesSsgEmploymentNoteTemplate = ssgSsgNotestemplatesSsgEmploymentNoteTemplate;
            SsgSsgNotestemplatesSsgIdentityNoteTemplate = ssgSsgNotestemplatesSsgIdentityNoteTemplate;
            SsgSsgNotestemplatesSsgPersonNotesTemplate = ssgSsgNotestemplatesSsgPersonNotesTemplate;
            SsgSsgNotestemplatesSsgNotesNoteTemplate = ssgSsgNotestemplatesSsgNotesNoteTemplate;
            SsgSsgNotestemplatesSsgAssetVehicleNoteTemplate = ssgSsgNotestemplatesSsgAssetVehicleNoteTemplate;
            SsgSsgNotestemplatesSsgAssetIcbcclaimNoteTemplate = ssgSsgNotestemplatesSsgAssetIcbcclaimNoteTemplate;
            SsgSsgNotestemplatesSsgAssetWorksafebcclaimNoteTemplate = ssgSsgNotestemplatesSsgAssetWorksafebcclaimNoteTemplate;
            SsgSsgNotestemplatesSsgAssetInvestmentNoteTemplate = ssgSsgNotestemplatesSsgAssetInvestmentNoteTemplate;
            SsgNotestemplatesSsgAssetBankinginformationNoteTemplate = ssgNotestemplatesSsgAssetBankinginformationNoteTemplate;
            SsgNotestemplatesSsgAssetOtherNoteTemplate = ssgNotestemplatesSsgAssetOtherNoteTemplate;
            SsgSsgNotestemplatesSsgAssetPensiondisabilityNoteTemplate = ssgSsgNotestemplatesSsgAssetPensiondisabilityNoteTemplate;
            SsgSsgNotestemplatesSsgAssetRealestatepropertyNoteTemplate = ssgSsgNotestemplatesSsgAssetRealestatepropertyNoteTemplate;
            SsgSsgNotestemplatesSsgSafetyconcerndetailNoteTemplate = ssgSsgNotestemplatesSsgSafetyconcerndetailNoteTemplate;
            SsgSsgNotestemplatesSsgAgencyDefaultresponsenote = ssgSsgNotestemplatesSsgAgencyDefaultresponsenote;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_description")]
        public string SsgDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_type")]
        public int? SsgType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplatesid")]
        public string SsgNotestemplatesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_typetext")]
        public string SsgTypetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "ssg_notestemplates_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgNotestemplatesSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgNotestemplatesDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgNotestemplatesDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgNotestemplatesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgNotestemplatesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgNotestemplatesProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgNotestemplatesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgNotestemplatesPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_address_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAddress> SsgSsgNotestemplatesSsgAddressNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_identifier_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgIdentifier> SsgSsgNotestemplatesSsgIdentifierNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_alias_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAlias> SsgSsgNotestemplatesSsgAliasNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_phonenumber_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgPhonenumber> SsgSsgNotestemplatesSsgPhonenumberNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_email_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgEmail> SsgSsgNotestemplatesSsgEmailNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_electronicaddress_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgElectronicaddress> SsgSsgNotestemplatesSsgElectronicaddressNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_employment_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgEmployment> SsgSsgNotestemplatesSsgEmploymentNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_identity_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgIdentity> SsgSsgNotestemplatesSsgIdentityNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_person_NotesTemplate")]
        public IList<MicrosoftDynamicsCRMssgPerson> SsgSsgNotestemplatesSsgPersonNotesTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_notes_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgNotes> SsgSsgNotestemplatesSsgNotesNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_asset_vehicle_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetVehicle> SsgSsgNotestemplatesSsgAssetVehicleNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_asset_icbcclaim_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetIcbcclaim> SsgSsgNotestemplatesSsgAssetIcbcclaimNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_asset_worksafebcclaim_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetWorksafebcclaim> SsgSsgNotestemplatesSsgAssetWorksafebcclaimNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_asset_investment_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetInvestment> SsgSsgNotestemplatesSsgAssetInvestmentNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_ssg_asset_bankinginformation_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetBankinginformation> SsgNotestemplatesSsgAssetBankinginformationNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notestemplates_ssg_asset_other_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetOther> SsgNotestemplatesSsgAssetOtherNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_asset_pensiondisability_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetPensiondisability> SsgSsgNotestemplatesSsgAssetPensiondisabilityNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_asset_realestateproperty_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> SsgSsgNotestemplatesSsgAssetRealestatepropertyNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_safetyconcerndetail_NoteTemplate")]
        public IList<MicrosoftDynamicsCRMssgSafetyconcerndetail> SsgSsgNotestemplatesSsgSafetyconcerndetailNoteTemplate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_notestemplates_ssg_agency_defaultresponsenote")]
        public IList<MicrosoftDynamicsCRMssgAgency> SsgSsgNotestemplatesSsgAgencyDefaultresponsenote { get; set; }

    }
}
