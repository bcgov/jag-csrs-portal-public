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
    /// Microsoft.Dynamics.CRM.ssg_ijsscase
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgIjsscase
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgIjsscase
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgIjsscase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMssgIjsscase
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMssgIjsscase(int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string ssgFmepcaseid2 = default(string), string ssgIjsscaseid = default(string), string ssgFmepcaseid1 = default(string), string _owneridValue = default(string), string versionnumber = default(string), string ssgAccessdbid = default(string), string _createdbyValue = default(string), string _owningteamValue = default(string), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), string ssgAutonumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ssgFilenumber = default(string), bool? ssgCasetype = default(bool?), string ssgStagingid = default(string), string _owningbusinessunitValue = default(string), string _ssgPartyoneidValue = default(string), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ssgStyleofcauserespondent = default(string), string ssgCasenumber = default(string), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), string ssgStyleofcauseapplicant = default(string), string ssgFis2number = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _ssgPartytwoidValue = default(string), int? ssgDatamigrationcount = default(int?), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgIjsscaseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> ssgIjsscaseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgIjsscaseMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgIjsscaseProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgIjsscaseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgIjsscasePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgIjssparty ssgPartyoneId = default(MicrosoftDynamicsCRMssgIjssparty), MicrosoftDynamicsCRMssgIjssparty ssgPartytwoId = default(MicrosoftDynamicsCRMssgIjssparty), IList<MicrosoftDynamicsCRMssgIjsschild> ssgIjsscaseSsgIjsschild = default(IList<MicrosoftDynamicsCRMssgIjsschild>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> ssgIjsscaseSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMactivitypointer> ssgIjsscaseActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> ssgIjsscaseAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> ssgIjsscaseEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> ssgIjsscaseFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> ssgIjsscaseLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> ssgIjsscasePhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> ssgIjsscaseTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ssgIjsscaseRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> ssgIjsscaseSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMserviceappointment> ssgIjsscaseServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMannotation> ssgIjsscaseAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMssgIjsscourtorder> ssgSsgIjsscaseSsgIjsscourtorderCaseNumber = default(IList<MicrosoftDynamicsCRMssgIjsscourtorder>), IList<MicrosoftDynamicsCRMssgIjssservicerequest> ssgIjsscaseSsgIjssservicerequestCaseNumber = default(IList<MicrosoftDynamicsCRMssgIjssservicerequest>), IList<MicrosoftDynamicsCRMafkWorkflowtask> ssgIjsscaseAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            SsgFmepcaseid2 = ssgFmepcaseid2;
            SsgIjsscaseid = ssgIjsscaseid;
            SsgFmepcaseid1 = ssgFmepcaseid1;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            SsgAccessdbid = ssgAccessdbid;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            SsgAutonumber = ssgAutonumber;
            Overriddencreatedon = overriddencreatedon;
            SsgFilenumber = ssgFilenumber;
            SsgCasetype = ssgCasetype;
            SsgStagingid = ssgStagingid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._ssgPartyoneidValue = _ssgPartyoneidValue;
            Statecode = statecode;
            Modifiedon = modifiedon;
            SsgStyleofcauserespondent = ssgStyleofcauserespondent;
            SsgCasenumber = ssgCasenumber;
            this._owninguserValue = _owninguserValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            SsgStyleofcauseapplicant = ssgStyleofcauseapplicant;
            SsgFis2number = ssgFis2number;
            Createdon = createdon;
            this._ssgPartytwoidValue = _ssgPartytwoidValue;
            SsgDatamigrationcount = ssgDatamigrationcount;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgIjsscaseSyncErrors = ssgIjsscaseSyncErrors;
            SsgIjsscaseAsyncOperations = ssgIjsscaseAsyncOperations;
            SsgIjsscaseMailboxTrackingFolders = ssgIjsscaseMailboxTrackingFolders;
            SsgIjsscaseProcessSession = ssgIjsscaseProcessSession;
            SsgIjsscaseBulkDeleteFailures = ssgIjsscaseBulkDeleteFailures;
            SsgIjsscasePrincipalObjectAttributeAccesses = ssgIjsscasePrincipalObjectAttributeAccesses;
            SsgPartyoneId = ssgPartyoneId;
            SsgPartytwoId = ssgPartytwoId;
            SsgIjsscaseSsgIjsschild = ssgIjsscaseSsgIjsschild;
            SsgIjsscaseSharePointDocumentLocations = ssgIjsscaseSharePointDocumentLocations;
            SsgIjsscaseActivityPointers = ssgIjsscaseActivityPointers;
            SsgIjsscaseAppointments = ssgIjsscaseAppointments;
            SsgIjsscaseEmails = ssgIjsscaseEmails;
            SsgIjsscaseFaxes = ssgIjsscaseFaxes;
            SsgIjsscaseLetters = ssgIjsscaseLetters;
            SsgIjsscasePhoneCalls = ssgIjsscasePhoneCalls;
            SsgIjsscaseTasks = ssgIjsscaseTasks;
            SsgIjsscaseRecurringAppointmentMasters = ssgIjsscaseRecurringAppointmentMasters;
            SsgIjsscaseSocialActivities = ssgIjsscaseSocialActivities;
            SsgIjsscaseServiceAppointments = ssgIjsscaseServiceAppointments;
            SsgIjsscaseAnnotations = ssgIjsscaseAnnotations;
            SsgSsgIjsscaseSsgIjsscourtorderCaseNumber = ssgSsgIjsscaseSsgIjsscourtorderCaseNumber;
            SsgIjsscaseSsgIjssservicerequestCaseNumber = ssgIjsscaseSsgIjssservicerequestCaseNumber;
            SsgIjsscaseAfkWorkflowtasks = ssgIjsscaseAfkWorkflowtasks;
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
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fmepcaseid2")]
        public string SsgFmepcaseid2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscaseid")]
        public string SsgIjsscaseid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fmepcaseid1")]
        public string SsgFmepcaseid1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_accessdbid")]
        public string SsgAccessdbid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumber")]
        public string SsgAutonumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_filenumber")]
        public string SsgFilenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_casetype")]
        public bool? SsgCasetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_stagingid")]
        public string SsgStagingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_partyoneid_value")]
        public string _ssgPartyoneidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_styleofcauserespondent")]
        public string SsgStyleofcauserespondent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_casenumber")]
        public string SsgCasenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_styleofcauseapplicant")]
        public string SsgStyleofcauseapplicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_fis2number")]
        public string SsgFis2number { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_partytwoid_value")]
        public string _ssgPartytwoidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_datamigrationcount")]
        public int? SsgDatamigrationcount { get; set; }

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
        [JsonProperty(PropertyName = "ssg_ijsscase_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgIjsscaseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgIjsscaseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgIjsscaseMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgIjsscaseProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgIjsscaseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgIjsscasePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_partyoneId")]
        public MicrosoftDynamicsCRMssgIjssparty SsgPartyoneId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_partytwoId")]
        public MicrosoftDynamicsCRMssgIjssparty SsgPartytwoId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_ssg_ijsschild")]
        public IList<MicrosoftDynamicsCRMssgIjsschild> SsgIjsscaseSsgIjsschild { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> SsgIjsscaseSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SsgIjsscaseActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> SsgIjsscaseAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_Emails")]
        public IList<MicrosoftDynamicsCRMemail> SsgIjsscaseEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> SsgIjsscaseFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_Letters")]
        public IList<MicrosoftDynamicsCRMletter> SsgIjsscaseLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> SsgIjsscasePhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> SsgIjsscaseTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SsgIjsscaseRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SsgIjsscaseSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SsgIjsscaseServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> SsgIjsscaseAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_ijsscase_ssg_ijsscourtorder_CaseNumber")]
        public IList<MicrosoftDynamicsCRMssgIjsscourtorder> SsgSsgIjsscaseSsgIjsscourtorderCaseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_ssg_ijssservicerequest_CaseNumber")]
        public IList<MicrosoftDynamicsCRMssgIjssservicerequest> SsgIjsscaseSsgIjssservicerequestCaseNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ijsscase_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMafkWorkflowtask> SsgIjsscaseAfkWorkflowtasks { get; set; }

    }
}
