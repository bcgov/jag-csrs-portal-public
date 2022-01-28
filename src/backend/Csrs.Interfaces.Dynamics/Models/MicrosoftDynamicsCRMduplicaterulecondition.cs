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
    /// Microsoft.Dynamics.CRM.duplicaterulecondition
    /// </summary>
    public partial class MicrosoftDynamicsCRMduplicaterulecondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterulecondition class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterulecondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterulecondition class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterulecondition(string _modifiedbyValue = default(string), string duplicateruleconditionid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string owningbusinessunit = default(string), string _createdonbehalfbyValue = default(string), string owninguser = default(string), bool? ignoreblankvalues = default(bool?), string baseattributename = default(string), string _owneridValue = default(string), int? operatorcode = default(int?), int? operatorparam = default(int?), string _createdbyValue = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string matchingattributename = default(string), IList<MicrosoftDynamicsCRMsyncerror> duplicateRuleConditionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMduplicaterule regardingobjectid = default(MicrosoftDynamicsCRMduplicaterule), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Duplicateruleconditionid = duplicateruleconditionid;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Owningbusinessunit = owningbusinessunit;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Owninguser = owninguser;
            Ignoreblankvalues = ignoreblankvalues;
            Baseattributename = baseattributename;
            this._owneridValue = _owneridValue;
            Operatorcode = operatorcode;
            Operatorparam = operatorparam;
            this._createdbyValue = _createdbyValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            Modifiedon = modifiedon;
            Matchingattributename = matchingattributename;
            DuplicateRuleConditionSyncErrors = duplicateRuleConditionSyncErrors;
            Regardingobjectid = regardingobjectid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duplicateruleconditionid")]
        public string Duplicateruleconditionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreblankvalues")]
        public bool? Ignoreblankvalues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseattributename")]
        public string Baseattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatorcode")]
        public int? Operatorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatorparam")]
        public int? Operatorparam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "matchingattributename")]
        public string Matchingattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DuplicateRuleCondition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DuplicateRuleConditionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMduplicaterule Regardingobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
