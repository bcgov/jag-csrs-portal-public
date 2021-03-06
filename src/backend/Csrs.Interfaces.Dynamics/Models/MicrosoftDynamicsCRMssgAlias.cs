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
    /// Microsoft.Dynamics.CRM.ssg_alias
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgAlias
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgAlias
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAlias()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgAlias
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAlias(bool? ssgCpcommentupdated = default(bool?), bool? ssgPersonnameprimaryindicator = default(bool?), string ssgSuppliernamedescription = default(string), string _modifiedonbehalfbyValue = default(string), int? ssgGenderoptionset = default(int?), int? ssgPersonnamecategorytext = default(int?), string ssgSuppliertypecode = default(string), string ssgDuplicatedetectionhash = default(string), bool? ssgAddtoresponse = default(bool?), System.DateTimeOffset? ssgPersonbirthdate = default(System.DateTimeOffset?), string ssgAgencyupdatedescription = default(string), bool? ssgRespcommentupdated = default(bool?), string ssgAddedtoresponseindicator = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string _ssgNotetemplateValue = default(string), System.DateTimeOffset? ssgDatadate2 = default(System.DateTimeOffset?), bool? ssgCopycpcomment = default(bool?), string versionnumber = default(string), string _createdbyValue = default(string), string ssgPersonsurname = default(string), int? importsequencenumber = default(int?), string _ssgConfirmedprofileValue = default(string), string ssgFams2Id = default(string), System.DateTimeOffset? ssgDatadate = default(System.DateTimeOffset?), string ssgAddedtocpbyuser = default(string), string _ssgResponseidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string ssgDatadatelabel2 = default(string), string ssgNotes = default(string), string ssgDatadatelabel = default(string), int? utcconversiontimezonecode = default(int?), bool? ssgUpdatedbyagency = default(bool?), string ssgResponsecomment = default(string), bool? ssgCreatedbyagency = default(bool?), int? ssgDatastatus = default(int?), string _owninguserValue = default(string), int? statecode = default(int?), string ssgPersonfullname = default(string), string _createdonbehalfbyValue = default(string), string ssgSuppliedbytext = default(string), string ssgPersonmiddlename = default(string), string _ssgPersonidValue = default(string), string _ssgCopycptosridValue = default(string), int? ssgSuppliedbyuser = default(int?), string ssgPersongivenname = default(string), string ssgFams2searchfileid = default(string), bool? ssgAddtocp = default(bool?), int? statuscode = default(int?), System.DateTimeOffset? ssgAddedtoconfirmedprofileon = default(System.DateTimeOffset?), int? ssgInformationsourcetext = default(int?), string ssgPersonthirdgivenname = default(string), string _modifiedbyValue = default(string), string ssgSearchrequesttext = default(string), bool? ssgCouldnotlocate = default(bool?), string _ssgResponsedatasummaryValue = default(string), string ssgConfirmcomment = default(string), string ssgAliasid = default(string), string _owneridValue = default(string), string _ssgSearchrequestValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgAliasSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAliasDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAliasDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgAliasAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgAliasMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgAliasProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgAliasBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgAliasPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest), IList<MicrosoftDynamicsCRMssgPhonenumber> ssgSsgAliasSsgPhonenumberAlias = default(IList<MicrosoftDynamicsCRMssgPhonenumber>), IList<MicrosoftDynamicsCRMssgIdentifier> ssgSsgAliasSsgIdentifierAlias = default(IList<MicrosoftDynamicsCRMssgIdentifier>), IList<MicrosoftDynamicsCRMssgAddress> ssgSsgAliasSsgAddressAlias = default(IList<MicrosoftDynamicsCRMssgAddress>), IList<MicrosoftDynamicsCRMssgEmail> ssgSsgAliasSsgEmailAlias = default(IList<MicrosoftDynamicsCRMssgEmail>), IList<MicrosoftDynamicsCRMssgElectronicaddress> ssgSsgAliasSsgElectronicaddressAlias = default(IList<MicrosoftDynamicsCRMssgElectronicaddress>), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfile = default(MicrosoftDynamicsCRMssgConfirmedprofile), MicrosoftDynamicsCRMssgSearchrequestresponse ssgResponseId = default(MicrosoftDynamicsCRMssgSearchrequestresponse), MicrosoftDynamicsCRMssgNotestemplates ssgNoteTemplate = default(MicrosoftDynamicsCRMssgNotestemplates), MicrosoftDynamicsCRMssgPerson ssgPersonId = default(MicrosoftDynamicsCRMssgPerson), MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold ssgCopyCpToSrId = default(MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold), IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> ssgAliasResulttransaction = default(IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction>), MicrosoftDynamicsCRMssgResponsedatasummary ssgResponseDataSummary = default(MicrosoftDynamicsCRMssgResponsedatasummary), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgAliasSsgRequestforinformationletterTemplateEntityAlias = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>))
        {
            SsgCpcommentupdated = ssgCpcommentupdated;
            SsgPersonnameprimaryindicator = ssgPersonnameprimaryindicator;
            SsgSuppliernamedescription = ssgSuppliernamedescription;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgGenderoptionset = ssgGenderoptionset;
            SsgPersonnamecategorytext = ssgPersonnamecategorytext;
            SsgSuppliertypecode = ssgSuppliertypecode;
            SsgDuplicatedetectionhash = ssgDuplicatedetectionhash;
            SsgAddtoresponse = ssgAddtoresponse;
            SsgPersonbirthdate = ssgPersonbirthdate;
            SsgAgencyupdatedescription = ssgAgencyupdatedescription;
            SsgRespcommentupdated = ssgRespcommentupdated;
            SsgAddedtoresponseindicator = ssgAddedtoresponseindicator;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._ssgNotetemplateValue = _ssgNotetemplateValue;
            SsgDatadate2 = ssgDatadate2;
            SsgCopycpcomment = ssgCopycpcomment;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            SsgPersonsurname = ssgPersonsurname;
            Importsequencenumber = importsequencenumber;
            this._ssgConfirmedprofileValue = _ssgConfirmedprofileValue;
            SsgFams2Id = ssgFams2Id;
            SsgDatadate = ssgDatadate;
            SsgAddedtocpbyuser = ssgAddedtocpbyuser;
            this._ssgResponseidValue = _ssgResponseidValue;
            Overriddencreatedon = overriddencreatedon;
            this._owningteamValue = _owningteamValue;
            Createdon = createdon;
            SsgDatadatelabel2 = ssgDatadatelabel2;
            SsgNotes = ssgNotes;
            SsgDatadatelabel = ssgDatadatelabel;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            SsgUpdatedbyagency = ssgUpdatedbyagency;
            SsgResponsecomment = ssgResponsecomment;
            SsgCreatedbyagency = ssgCreatedbyagency;
            SsgDatastatus = ssgDatastatus;
            this._owninguserValue = _owninguserValue;
            Statecode = statecode;
            SsgPersonfullname = ssgPersonfullname;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SsgSuppliedbytext = ssgSuppliedbytext;
            SsgPersonmiddlename = ssgPersonmiddlename;
            this._ssgPersonidValue = _ssgPersonidValue;
            this._ssgCopycptosridValue = _ssgCopycptosridValue;
            SsgSuppliedbyuser = ssgSuppliedbyuser;
            SsgPersongivenname = ssgPersongivenname;
            SsgFams2searchfileid = ssgFams2searchfileid;
            SsgAddtocp = ssgAddtocp;
            Statuscode = statuscode;
            SsgAddedtoconfirmedprofileon = ssgAddedtoconfirmedprofileon;
            SsgInformationsourcetext = ssgInformationsourcetext;
            SsgPersonthirdgivenname = ssgPersonthirdgivenname;
            this._modifiedbyValue = _modifiedbyValue;
            SsgSearchrequesttext = ssgSearchrequesttext;
            SsgCouldnotlocate = ssgCouldnotlocate;
            this._ssgResponsedatasummaryValue = _ssgResponsedatasummaryValue;
            SsgConfirmcomment = ssgConfirmcomment;
            SsgAliasid = ssgAliasid;
            this._owneridValue = _owneridValue;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgAliasSyncErrors = ssgAliasSyncErrors;
            SsgAliasDuplicateMatchingRecord = ssgAliasDuplicateMatchingRecord;
            SsgAliasDuplicateBaseRecord = ssgAliasDuplicateBaseRecord;
            SsgAliasAsyncOperations = ssgAliasAsyncOperations;
            SsgAliasMailboxTrackingFolders = ssgAliasMailboxTrackingFolders;
            SsgAliasProcessSession = ssgAliasProcessSession;
            SsgAliasBulkDeleteFailures = ssgAliasBulkDeleteFailures;
            SsgAliasPrincipalObjectAttributeAccesses = ssgAliasPrincipalObjectAttributeAccesses;
            SsgSearchRequest = ssgSearchRequest;
            SsgSsgAliasSsgPhonenumberAlias = ssgSsgAliasSsgPhonenumberAlias;
            SsgSsgAliasSsgIdentifierAlias = ssgSsgAliasSsgIdentifierAlias;
            SsgSsgAliasSsgAddressAlias = ssgSsgAliasSsgAddressAlias;
            SsgSsgAliasSsgEmailAlias = ssgSsgAliasSsgEmailAlias;
            SsgSsgAliasSsgElectronicaddressAlias = ssgSsgAliasSsgElectronicaddressAlias;
            SsgConfirmedProfile = ssgConfirmedProfile;
            SsgResponseId = ssgResponseId;
            SsgNoteTemplate = ssgNoteTemplate;
            SsgPersonId = ssgPersonId;
            SsgCopyCpToSrId = ssgCopyCpToSrId;
            SsgAliasResulttransaction = ssgAliasResulttransaction;
            SsgResponseDataSummary = ssgResponseDataSummary;
            SsgSsgAliasSsgRequestforinformationletterTemplateEntityAlias = ssgSsgAliasSsgRequestforinformationletterTemplateEntityAlias;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_cpcommentupdated")]
        public bool? SsgCpcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personnameprimaryindicator")]
        public bool? SsgPersonnameprimaryindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliernamedescription")]
        public string SsgSuppliernamedescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_genderoptionset")]
        public int? SsgGenderoptionset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personnamecategorytext")]
        public int? SsgPersonnamecategorytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliertypecode")]
        public string SsgSuppliertypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_duplicatedetectionhash")]
        public string SsgDuplicatedetectionhash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtoresponse")]
        public bool? SsgAddtoresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personbirthdate")]
        public System.DateTimeOffset? SsgPersonbirthdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_agencyupdatedescription")]
        public string SsgAgencyupdatedescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_respcommentupdated")]
        public bool? SsgRespcommentupdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoresponseindicator")]
        public string SsgAddedtoresponseindicator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_notetemplate_value")]
        public string _ssgNotetemplateValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate2")]
        public System.DateTimeOffset? SsgDatadate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_copycpcomment")]
        public bool? SsgCopycpcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personsurname")]
        public string SsgPersonsurname { get; set; }

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
        [JsonProperty(PropertyName = "ssg_fams2_id")]
        public string SsgFams2Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadate")]
        public System.DateTimeOffset? SsgDatadate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtocpbyuser")]
        public string SsgAddedtocpbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responseid_value")]
        public string _ssgResponseidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel2")]
        public string SsgDatadatelabel2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_notes")]
        public string SsgNotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datadatelabel")]
        public string SsgDatadatelabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_updatedbyagency")]
        public bool? SsgUpdatedbyagency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_responsecomment")]
        public string SsgResponsecomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_createdbyagency")]
        public bool? SsgCreatedbyagency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datastatus")]
        public int? SsgDatastatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personfullname")]
        public string SsgPersonfullname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbytext")]
        public string SsgSuppliedbytext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personmiddlename")]
        public string SsgPersonmiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_personid_value")]
        public string _ssgPersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_copycptosrid_value")]
        public string _ssgCopycptosridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_suppliedbyuser")]
        public int? SsgSuppliedbyuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_persongivenname")]
        public string SsgPersongivenname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fams2searchfileid")]
        public string SsgFams2searchfileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addtocp")]
        public bool? SsgAddtocp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_addedtoconfirmedprofileon")]
        public System.DateTimeOffset? SsgAddedtoconfirmedprofileon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_informationsourcetext")]
        public int? SsgInformationsourcetext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_personthirdgivenname")]
        public string SsgPersonthirdgivenname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequesttext")]
        public string SsgSearchrequesttext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_couldnotlocate")]
        public bool? SsgCouldnotlocate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_responsedatasummary_value")]
        public string _ssgResponsedatasummaryValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_confirmcomment")]
        public string SsgConfirmcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_aliasid")]
        public string SsgAliasid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

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
        [JsonProperty(PropertyName = "ssg_alias_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgAliasSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAliasDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAliasDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgAliasAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgAliasMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgAliasProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgAliasBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgAliasPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_alias_ssg_phonenumber_Alias")]
        public IList<MicrosoftDynamicsCRMssgPhonenumber> SsgSsgAliasSsgPhonenumberAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_alias_ssg_identifier_Alias")]
        public IList<MicrosoftDynamicsCRMssgIdentifier> SsgSsgAliasSsgIdentifierAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_alias_ssg_address_Alias")]
        public IList<MicrosoftDynamicsCRMssgAddress> SsgSsgAliasSsgAddressAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_alias_ssg_email_Alias")]
        public IList<MicrosoftDynamicsCRMssgEmail> SsgSsgAliasSsgEmailAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_alias_ssg_electronicaddress_Alias")]
        public IList<MicrosoftDynamicsCRMssgElectronicaddress> SsgSsgAliasSsgElectronicaddressAlias { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfile")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseId")]
        public MicrosoftDynamicsCRMssgSearchrequestresponse SsgResponseId { get; set; }

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
        [JsonProperty(PropertyName = "ssg_CopyCpToSrId")]
        public MicrosoftDynamicsCRMssgCopysearchrequesttoconfirmedprofilehold SsgCopyCpToSrId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_alias__resulttransaction")]
        public IList<MicrosoftDynamicsCRMssgSearchrequestresulttransaction> SsgAliasResulttransaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ResponseDataSummary")]
        public MicrosoftDynamicsCRMssgResponsedatasummary SsgResponseDataSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_alias_ssg_requestforinformationletter_TemplateEntity_Alias")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgAliasSsgRequestforinformationletterTemplateEntityAlias { get; set; }

    }
}
