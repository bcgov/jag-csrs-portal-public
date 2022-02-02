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
    /// Microsoft.Dynamics.CRM.ssg_resendresponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgResendresponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgResendresponse class.
        /// </summary>
        public MicrosoftDynamicsCRMssgResendresponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgResendresponse class.
        /// </summary>
        public MicrosoftDynamicsCRMssgResendresponse(string _owningteamValue = default(string), string _owningbusinessunitValue = default(string), string versionnumber = default(string), string ssgName = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), int? ssgSendmethod = default(int?), string _createdbyValue = default(string), string ssgSendto = default(string), string _owneridValue = default(string), int? statuscode = default(int?), string ssgResendresponseid = default(string), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string _ssgSearchrequestValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgResendresponseSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> ssgResendresponseAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgResendresponseMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgResendresponseProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgResendresponseBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgResendresponsePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgSearchrequest ssgSearchRequest = default(MicrosoftDynamicsCRMssgSearchrequest))
        {
            this._owningteamValue = _owningteamValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            SsgName = ssgName;
            Createdon = createdon;
            Statecode = statecode;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            SsgSendmethod = ssgSendmethod;
            this._createdbyValue = _createdbyValue;
            SsgSendto = ssgSendto;
            this._owneridValue = _owneridValue;
            Statuscode = statuscode;
            SsgResendresponseid = ssgResendresponseid;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._ssgSearchrequestValue = _ssgSearchrequestValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgResendresponseSyncErrors = ssgResendresponseSyncErrors;
            SsgResendresponseAsyncOperations = ssgResendresponseAsyncOperations;
            SsgResendresponseMailboxTrackingFolders = ssgResendresponseMailboxTrackingFolders;
            SsgResendresponseProcessSession = ssgResendresponseProcessSession;
            SsgResendresponseBulkDeleteFailures = ssgResendresponseBulkDeleteFailures;
            SsgResendresponsePrincipalObjectAttributeAccesses = ssgResendresponsePrincipalObjectAttributeAccesses;
            SsgSearchRequest = ssgSearchRequest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_sendmethod")]
        public int? SsgSendmethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_sendto")]
        public string SsgSendto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_resendresponseid")]
        public string SsgResendresponseid { get; set; }

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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "ssg_resendresponse_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgResendresponseSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_resendresponse_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgResendresponseAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_resendresponse_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgResendresponseMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_resendresponse_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgResendresponseProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_resendresponse_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgResendresponseBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_resendresponse_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgResendresponsePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_SearchRequest")]
        public MicrosoftDynamicsCRMssgSearchrequest SsgSearchRequest { get; set; }

    }
}