// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.audit
    /// </summary>
    public partial class MicrosoftDynamicsCRMaudit
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMaudit class.
        /// </summary>
        public MicrosoftDynamicsCRMaudit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMaudit class.
        /// </summary>
        public MicrosoftDynamicsCRMaudit(int? operation = default(int?), string _regardingobjectidValue = default(string), int? action = default(int?), string useradditionalinfo = default(string), string attributemask = default(string), string _useridValue = default(string), string _callinguseridValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _objectidValue = default(string), string transactionid = default(string), string auditid = default(string), MicrosoftDynamicsCRMsystemuser callinguserid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser userid = default(MicrosoftDynamicsCRMsystemuser))
        {
            Operation = operation;
            this._regardingobjectidValue = _regardingobjectidValue;
            Action = action;
            Useradditionalinfo = useradditionalinfo;
            Attributemask = attributemask;
            this._useridValue = _useridValue;
            this._callinguseridValue = _callinguseridValue;
            Createdon = createdon;
            this._objectidValue = _objectidValue;
            Transactionid = transactionid;
            Auditid = auditid;
            Callinguserid = callinguserid;
            Userid = userid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public int? Operation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public int? Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "useradditionalinfo")]
        public string Useradditionalinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributemask")]
        public string Attributemask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_userid_value")]
        public string _useridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_callinguserid_value")]
        public string _callinguseridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactionid")]
        public string Transactionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "auditid")]
        public string Auditid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "callinguserid")]
        public MicrosoftDynamicsCRMsystemuser Callinguserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userid")]
        public MicrosoftDynamicsCRMsystemuser Userid { get; set; }

    }
}