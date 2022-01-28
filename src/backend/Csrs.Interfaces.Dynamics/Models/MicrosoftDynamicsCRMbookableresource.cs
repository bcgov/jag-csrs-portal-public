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
    /// Microsoft.Dynamics.CRM.bookableresource
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresource class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresource class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresource(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _calendaridValue = default(string), string _owneridValue = default(string), string stageid = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), string traversedpath = default(string), string versionnumber = default(string), string _accountidValue = default(string), int? resourcetype = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statuscode = default(int?), string _transactioncurrencyidValue = default(string), string bookableresourceid = default(string), string _contactidValue = default(string), int? timezone = default(int?), string _useridValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), int? statecode = default(int?), string _owningteamValue = default(string), string processid = default(string), string _createdonbehalfbyValue = default(string), string _owninguserValue = default(string), decimal? exchangerate = default(decimal?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourceDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourceDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bookableresourceMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> bookableresourceProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bookableresourcePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> bookableresourceAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMaccount accountId = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMbookableresourcebooking> bookableresourceBookableresourcebookingResource = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> bookableresourceBookableresourcecategoryassnResource = default(IList<MicrosoftDynamicsCRMbookableresourcecategoryassn>), IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> bookableresourceBookableresourcecharacteristicResource = default(IList<MicrosoftDynamicsCRMbookableresourcecharacteristic>), IList<MicrosoftDynamicsCRMbookableresourcegroup> bookableresourceBookableresourcegroupChildResource = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), IList<MicrosoftDynamicsCRMbookableresourcegroup> bookableresourceBookableresourcegroupParentResource = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMcontact contactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser userId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Createdon = createdon;
            this._calendaridValue = _calendaridValue;
            this._owneridValue = _owneridValue;
            Stageid = stageid;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Traversedpath = traversedpath;
            Versionnumber = versionnumber;
            this._accountidValue = _accountidValue;
            Resourcetype = resourcetype;
            Modifiedon = modifiedon;
            Name = name;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Bookableresourceid = bookableresourceid;
            this._contactidValue = _contactidValue;
            Timezone = timezone;
            this._useridValue = _useridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            Processid = processid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            Exchangerate = exchangerate;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableResourceSyncErrors = bookableResourceSyncErrors;
            BookableresourceDuplicateMatchingRecord = bookableresourceDuplicateMatchingRecord;
            BookableresourceDuplicateBaseRecord = bookableresourceDuplicateBaseRecord;
            BookableresourceAsyncOperations = bookableresourceAsyncOperations;
            BookableresourceMailboxTrackingFolders = bookableresourceMailboxTrackingFolders;
            BookableresourceProcessSession = bookableresourceProcessSession;
            BookableresourceBulkDeleteFailures = bookableresourceBulkDeleteFailures;
            BookableresourcePrincipalObjectAttributeAccesses = bookableresourcePrincipalObjectAttributeAccesses;
            BookableresourceAnnotations = bookableresourceAnnotations;
            AccountId = accountId;
            BookableresourceBookableresourcebookingResource = bookableresourceBookableresourcebookingResource;
            BookableresourceBookableresourcecategoryassnResource = bookableresourceBookableresourcecategoryassnResource;
            BookableresourceBookableresourcecharacteristicResource = bookableresourceBookableresourcecharacteristicResource;
            BookableresourceBookableresourcegroupChildResource = bookableresourceBookableresourcegroupChildResource;
            BookableresourceBookableresourcegroupParentResource = bookableresourceBookableresourcegroupParentResource;
            Calendarid = calendarid;
            ContactId = contactId;
            UserId = userId;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourcetype")]
        public int? Resourcetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourceid")]
        public string Bookableresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_userid_value")]
        public string _useridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "BookableResource_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourceDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourceDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BookableresourceMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> BookableresourceProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BookableresourcePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BookableresourceAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountId")]
        public MicrosoftDynamicsCRMaccount AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcebooking_Resource")]
        public IList<MicrosoftDynamicsCRMbookableresourcebooking> BookableresourceBookableresourcebookingResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcecategoryassn_Resource")]
        public IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> BookableresourceBookableresourcecategoryassnResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcecharacteristic_Resource")]
        public IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> BookableresourceBookableresourcecharacteristicResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcegroup_ChildResource")]
        public IList<MicrosoftDynamicsCRMbookableresourcegroup> BookableresourceBookableresourcegroupChildResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcegroup_ParentResource")]
        public IList<MicrosoftDynamicsCRMbookableresourcegroup> BookableresourceBookableresourcegroupParentResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactId")]
        public MicrosoftDynamicsCRMcontact ContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public MicrosoftDynamicsCRMsystemuser UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
