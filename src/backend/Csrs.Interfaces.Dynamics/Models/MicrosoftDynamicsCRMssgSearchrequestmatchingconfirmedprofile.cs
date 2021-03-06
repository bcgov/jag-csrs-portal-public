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
    /// Microsoft.Dynamics.CRM.ssg_searchrequestmatchingconfirmedprofile
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgSearchrequestmatchingconfirmedprofile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgSearchrequestmatchingconfirmedprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMssgSearchrequestmatchingconfirmedprofile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgSearchrequestmatchingconfirmedprofile class.
        /// </summary>
        public MicrosoftDynamicsCRMssgSearchrequestmatchingconfirmedprofile(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string ssgName = default(string), string _owninguserValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), string ssgMatchedon = default(string), string _createdonbehalfbyValue = default(string), string ssgSearchrequestmatchingconfirmedprofileid = default(string), string _owneridValue = default(string), int? statecode = default(int?), string _owningteamValue = default(string), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string _ssgConfirmedprofileidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _ssgSearchrequestidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), string ssgPersonsought = default(string), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgSearchrequestmatchingconfirmedprofileSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgSearchrequestmatchingconfirmedprofileDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgSearchrequestmatchingconfirmedprofileDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgSearchrequestmatchingconfirmedprofileAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgSearchrequestmatchingconfirmedprofileMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgSearchrequestmatchingconfirmedprofileProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgSearchrequestmatchingconfirmedprofileBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgSearchrequestmatchingconfirmedprofilePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequestId = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgConfirmedprofile ssgConfirmedProfileId = default(MicrosoftDynamicsCRMssgConfirmedprofile))
        {
            Createdon = createdon;
            SsgName = ssgName;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            SsgMatchedon = ssgMatchedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SsgSearchrequestmatchingconfirmedprofileid = ssgSearchrequestmatchingconfirmedprofileid;
            this._owneridValue = _owneridValue;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._ssgConfirmedprofileidValue = _ssgConfirmedprofileidValue;
            Overriddencreatedon = overriddencreatedon;
            this._ssgSearchrequestidValue = _ssgSearchrequestidValue;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            SsgPersonsought = ssgPersonsought;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgSearchrequestmatchingconfirmedprofileSyncErrors = ssgSearchrequestmatchingconfirmedprofileSyncErrors;
            SsgSearchrequestmatchingconfirmedprofileDuplicateMatchingRecord = ssgSearchrequestmatchingconfirmedprofileDuplicateMatchingRecord;
            SsgSearchrequestmatchingconfirmedprofileDuplicateBaseRecord = ssgSearchrequestmatchingconfirmedprofileDuplicateBaseRecord;
            SsgSearchrequestmatchingconfirmedprofileAsyncOperations = ssgSearchrequestmatchingconfirmedprofileAsyncOperations;
            SsgSearchrequestmatchingconfirmedprofileMailboxTrackingFolders = ssgSearchrequestmatchingconfirmedprofileMailboxTrackingFolders;
            SsgSearchrequestmatchingconfirmedprofileProcessSession = ssgSearchrequestmatchingconfirmedprofileProcessSession;
            SsgSearchrequestmatchingconfirmedprofileBulkDeleteFailures = ssgSearchrequestmatchingconfirmedprofileBulkDeleteFailures;
            SsgSearchrequestmatchingconfirmedprofilePrincipalObjectAttributeAccesses = ssgSearchrequestmatchingconfirmedprofilePrincipalObjectAttributeAccesses;
            SsgSearchRequestId = ssgSearchRequestId;
            SsgConfirmedProfileId = ssgConfirmedProfileId;
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
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_matchedon")]
        public string SsgMatchedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofileid")]
        public string SsgSearchrequestmatchingconfirmedprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

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
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_confirmedprofileid_value")]
        public string _ssgConfirmedprofileidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_searchrequestid_value")]
        public string _ssgSearchrequestidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "ssg_personsought")]
        public string SsgPersonsought { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgSearchrequestmatchingconfirmedprofileSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgSearchrequestmatchingconfirmedprofileDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgSearchrequestmatchingconfirmedprofileDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgSearchrequestmatchingconfirmedprofileAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgSearchrequestmatchingconfirmedprofileMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgSearchrequestmatchingconfirmedprofileProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgSearchrequestmatchingconfirmedprofileBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_searchrequestmatchingconfirmedprofile_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgSearchrequestmatchingconfirmedprofilePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequestId")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ConfirmedProfileId")]
        public MicrosoftDynamicsCRMssgConfirmedprofile SsgConfirmedProfileId { get; set; }

    }
}
