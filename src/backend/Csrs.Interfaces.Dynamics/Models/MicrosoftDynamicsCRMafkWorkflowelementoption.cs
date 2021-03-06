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
    /// Microsoft.Dynamics.CRM.afk_workflowelementoption
    /// </summary>
    public partial class MicrosoftDynamicsCRMafkWorkflowelementoption
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMafkWorkflowelementoption class.
        /// </summary>
        public MicrosoftDynamicsCRMafkWorkflowelementoption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMafkWorkflowelementoption class.
        /// </summary>
        public MicrosoftDynamicsCRMafkWorkflowelementoption(int? afkDatetimeunits = default(int?), string afkWorkflowelementoptionid = default(string), string _owneridValue = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? afkComparisonresult = default(int?), int? afkIsolationmode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? afkZerototen = default(int?), int? statuscode = default(int?), string _owningteamValue = default(string), int? afkEmailrecipient = default(int?), int? afkTimespanoption = default(int?), string _modifiedbyValue = default(string), int? statecode = default(int?), int? afkDatetimeformats = default(int?), string _owninguserValue = default(string), string _owningbusinessunitValue = default(string), int? afkHtmlcolorname = default(int?), int? afkFetchxmlmultipleresultoptions = default(int?), string _createdbyValue = default(string), int? afkWorkflowcategory = default(int?), int? afkTimezones = default(int?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string versionnumber = default(string), int? afkExtendedtimezones = default(int?), int? afkSynchronousmode = default(int?), int? utcconversiontimezonecode = default(int?), int? afkDayofweek = default(int?), string afkName = default(string), int? afkMonthofyear = default(int?), int? afkFetchxmlnoresultoptions = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> afkWorkflowelementoptionActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> afkWorkflowelementoptionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> afkWorkflowelementoptionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> afkWorkflowelementoptionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> afkWorkflowelementoptionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> afkWorkflowelementoptionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> afkWorkflowelementoptionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> afkWorkflowelementoptionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> afkWorkflowelementoptionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> afkWorkflowelementoptionAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> afkWorkflowelementoptionEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> afkWorkflowelementoptionFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> afkWorkflowelementoptionLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> afkWorkflowelementoptionPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> afkWorkflowelementoptionTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> afkWorkflowelementoptionRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> afkWorkflowelementoptionSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> afkWorkflowelementoptionConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> afkWorkflowelementoptionConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> afkWorkflowelementoptionAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMserviceappointment> afkWorkflowelementoptionServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMafkWorkflowtask> afkWorkflowelementoptionAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>))
        {
            AfkDatetimeunits = afkDatetimeunits;
            AfkWorkflowelementoptionid = afkWorkflowelementoptionid;
            this._owneridValue = _owneridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AfkComparisonresult = afkComparisonresult;
            AfkIsolationmode = afkIsolationmode;
            Createdon = createdon;
            AfkZerototen = afkZerototen;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            AfkEmailrecipient = afkEmailrecipient;
            AfkTimespanoption = afkTimespanoption;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            AfkDatetimeformats = afkDatetimeformats;
            this._owninguserValue = _owninguserValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AfkHtmlcolorname = afkHtmlcolorname;
            AfkFetchxmlmultipleresultoptions = afkFetchxmlmultipleresultoptions;
            this._createdbyValue = _createdbyValue;
            AfkWorkflowcategory = afkWorkflowcategory;
            AfkTimezones = afkTimezones;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            AfkExtendedtimezones = afkExtendedtimezones;
            AfkSynchronousmode = afkSynchronousmode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AfkDayofweek = afkDayofweek;
            AfkName = afkName;
            AfkMonthofyear = afkMonthofyear;
            AfkFetchxmlnoresultoptions = afkFetchxmlnoresultoptions;
            Modifiedon = modifiedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AfkWorkflowelementoptionActivityPointers = afkWorkflowelementoptionActivityPointers;
            AfkWorkflowelementoptionSyncErrors = afkWorkflowelementoptionSyncErrors;
            AfkWorkflowelementoptionDuplicateMatchingRecord = afkWorkflowelementoptionDuplicateMatchingRecord;
            AfkWorkflowelementoptionDuplicateBaseRecord = afkWorkflowelementoptionDuplicateBaseRecord;
            AfkWorkflowelementoptionAsyncOperations = afkWorkflowelementoptionAsyncOperations;
            AfkWorkflowelementoptionMailboxTrackingFolders = afkWorkflowelementoptionMailboxTrackingFolders;
            AfkWorkflowelementoptionProcessSession = afkWorkflowelementoptionProcessSession;
            AfkWorkflowelementoptionBulkDeleteFailures = afkWorkflowelementoptionBulkDeleteFailures;
            AfkWorkflowelementoptionPrincipalObjectAttributeAccesses = afkWorkflowelementoptionPrincipalObjectAttributeAccesses;
            AfkWorkflowelementoptionAppointments = afkWorkflowelementoptionAppointments;
            AfkWorkflowelementoptionEmails = afkWorkflowelementoptionEmails;
            AfkWorkflowelementoptionFaxes = afkWorkflowelementoptionFaxes;
            AfkWorkflowelementoptionLetters = afkWorkflowelementoptionLetters;
            AfkWorkflowelementoptionPhoneCalls = afkWorkflowelementoptionPhoneCalls;
            AfkWorkflowelementoptionTasks = afkWorkflowelementoptionTasks;
            AfkWorkflowelementoptionRecurringAppointmentMasters = afkWorkflowelementoptionRecurringAppointmentMasters;
            AfkWorkflowelementoptionSocialActivities = afkWorkflowelementoptionSocialActivities;
            AfkWorkflowelementoptionConnections1 = afkWorkflowelementoptionConnections1;
            AfkWorkflowelementoptionConnections2 = afkWorkflowelementoptionConnections2;
            AfkWorkflowelementoptionAnnotations = afkWorkflowelementoptionAnnotations;
            AfkWorkflowelementoptionServiceAppointments = afkWorkflowelementoptionServiceAppointments;
            AfkWorkflowelementoptionAfkWorkflowtasks = afkWorkflowelementoptionAfkWorkflowtasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_datetimeunits")]
        public int? AfkDatetimeunits { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoptionid")]
        public string AfkWorkflowelementoptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_comparisonresult")]
        public int? AfkComparisonresult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_isolationmode")]
        public int? AfkIsolationmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_zerototen")]
        public int? AfkZerototen { get; set; }

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
        [JsonProperty(PropertyName = "afk_emailrecipient")]
        public int? AfkEmailrecipient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_timespanoption")]
        public int? AfkTimespanoption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_datetimeformats")]
        public int? AfkDatetimeformats { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_htmlcolorname")]
        public int? AfkHtmlcolorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_fetchxmlmultipleresultoptions")]
        public int? AfkFetchxmlmultipleresultoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowcategory")]
        public int? AfkWorkflowcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_timezones")]
        public int? AfkTimezones { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_extendedtimezones")]
        public int? AfkExtendedtimezones { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_synchronousmode")]
        public int? AfkSynchronousmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_dayofweek")]
        public int? AfkDayofweek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_name")]
        public string AfkName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_monthofyear")]
        public int? AfkMonthofyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_fetchxmlnoresultoptions")]
        public int? AfkFetchxmlnoresultoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "afk_workflowelementoption_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AfkWorkflowelementoptionActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AfkWorkflowelementoptionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AfkWorkflowelementoptionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AfkWorkflowelementoptionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AfkWorkflowelementoptionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AfkWorkflowelementoptionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AfkWorkflowelementoptionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AfkWorkflowelementoptionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AfkWorkflowelementoptionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AfkWorkflowelementoptionAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AfkWorkflowelementoptionEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AfkWorkflowelementoptionFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AfkWorkflowelementoptionLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AfkWorkflowelementoptionPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AfkWorkflowelementoptionTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AfkWorkflowelementoptionRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AfkWorkflowelementoptionSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> AfkWorkflowelementoptionConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> AfkWorkflowelementoptionConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AfkWorkflowelementoptionAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AfkWorkflowelementoptionServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "afk_workflowelementoption_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMafkWorkflowtask> AfkWorkflowelementoptionAfkWorkflowtasks { get; set; }

    }
}
