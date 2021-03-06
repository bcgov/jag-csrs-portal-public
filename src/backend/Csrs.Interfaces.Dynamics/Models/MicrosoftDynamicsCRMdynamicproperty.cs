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
    /// Microsoft.Dynamics.CRM.dynamicproperty
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicproperty
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicproperty class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicproperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicproperty class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicproperty(string versionnumber = default(string), string _basedynamicpropertyidValue = default(string), bool? isreadonly = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? defaultvalueinteger = default(int?), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), int? dmtimportstate = default(int?), int? utcconversiontimezonecode = default(int?), int? maxvalueinteger = default(int?), decimal? maxvaluedouble = default(decimal?), decimal? minvaluedecimal = default(decimal?), string name = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string rootdynamicpropertyid = default(string), string _createdonbehalfbyValue = default(string), string description = default(string), decimal? defaultvaluedouble = default(decimal?), string overwrittendynamicpropertyid = default(string), string _modifiedbyValue = default(string), int? maxlengthstring = default(int?), string defaultvaluestring = default(string), string _organizationidValue = default(string), string _defaultvalueoptionsetValue = default(string), decimal? defaultvaluedecimal = default(decimal?), bool? ishidden = default(bool?), int? statuscode = default(int?), bool? isrequired = default(bool?), int? precision = default(int?), string dynamicpropertyid = default(string), string _regardingobjectidValue = default(string), int? minvalueinteger = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), decimal? minvaluedouble = default(decimal?), int? datatype = default(int?), decimal? maxvaluedecimal = default(decimal?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> dynamicpropertySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> dynamicpropertyAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> dynamicpropertyMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> dynamicpropertyBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> dynamicpropertyPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMdynamicproperty basedynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), IList<MicrosoftDynamicsCRMdynamicproperty> dynamicpropertyBaseDynamicproperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), MicrosoftDynamicsCRMdynamicpropertyoptionsetitem dynamicpropertyoptionsetvalueid = default(MicrosoftDynamicsCRMdynamicpropertyoptionsetitem), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> dynamicpropertyDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), IList<MicrosoftDynamicsCRMdynamicpropertyinstance> dynamicPropertyDynamicPropertyInstance = default(IList<MicrosoftDynamicsCRMdynamicpropertyinstance>), IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem> dynamicPropertyDynamicPropertyOptionSetItem = default(IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem>), MicrosoftDynamicsCRMproduct regardingobjectidProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMproductassociation regardingobjectidProductassociation = default(MicrosoftDynamicsCRMproductassociation))
        {
            Versionnumber = versionnumber;
            this._basedynamicpropertyidValue = _basedynamicpropertyidValue;
            Isreadonly = isreadonly;
            Overriddencreatedon = overriddencreatedon;
            Defaultvalueinteger = defaultvalueinteger;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            Dmtimportstate = dmtimportstate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Maxvalueinteger = maxvalueinteger;
            Maxvaluedouble = maxvaluedouble;
            Minvaluedecimal = minvaluedecimal;
            Name = name;
            Modifiedon = modifiedon;
            Rootdynamicpropertyid = rootdynamicpropertyid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Description = description;
            Defaultvaluedouble = defaultvaluedouble;
            Overwrittendynamicpropertyid = overwrittendynamicpropertyid;
            this._modifiedbyValue = _modifiedbyValue;
            Maxlengthstring = maxlengthstring;
            Defaultvaluestring = defaultvaluestring;
            this._organizationidValue = _organizationidValue;
            this._defaultvalueoptionsetValue = _defaultvalueoptionsetValue;
            Defaultvaluedecimal = defaultvaluedecimal;
            Ishidden = ishidden;
            Statuscode = statuscode;
            Isrequired = isrequired;
            Precision = precision;
            Dynamicpropertyid = dynamicpropertyid;
            this._regardingobjectidValue = _regardingobjectidValue;
            Minvalueinteger = minvalueinteger;
            Createdon = createdon;
            Importsequencenumber = importsequencenumber;
            Minvaluedouble = minvaluedouble;
            Datatype = datatype;
            Maxvaluedecimal = maxvaluedecimal;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            DynamicpropertySyncErrors = dynamicpropertySyncErrors;
            DynamicpropertyAsyncOperations = dynamicpropertyAsyncOperations;
            DynamicpropertyMailboxTrackingFolders = dynamicpropertyMailboxTrackingFolders;
            DynamicpropertyBulkDeleteFailures = dynamicpropertyBulkDeleteFailures;
            DynamicpropertyPrincipalObjectAttributeAccesses = dynamicpropertyPrincipalObjectAttributeAccesses;
            Basedynamicpropertyid = basedynamicpropertyid;
            DynamicpropertyBaseDynamicproperty = dynamicpropertyBaseDynamicproperty;
            Dynamicpropertyoptionsetvalueid = dynamicpropertyoptionsetvalueid;
            DynamicpropertyDynamicPropertyAssociation = dynamicpropertyDynamicPropertyAssociation;
            DynamicPropertyDynamicPropertyInstance = dynamicPropertyDynamicPropertyInstance;
            DynamicPropertyDynamicPropertyOptionSetItem = dynamicPropertyDynamicPropertyOptionSetItem;
            RegardingobjectidProduct = regardingobjectidProduct;
            RegardingobjectidProductassociation = regardingobjectidProductassociation;
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
        [JsonProperty(PropertyName = "_basedynamicpropertyid_value")]
        public string _basedynamicpropertyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isreadonly")]
        public bool? Isreadonly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvalueinteger")]
        public int? Defaultvalueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

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
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxvalueinteger")]
        public int? Maxvalueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxvaluedouble")]
        public decimal? Maxvaluedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minvaluedecimal")]
        public decimal? Minvaluedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootdynamicpropertyid")]
        public string Rootdynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvaluedouble")]
        public decimal? Defaultvaluedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwrittendynamicpropertyid")]
        public string Overwrittendynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxlengthstring")]
        public int? Maxlengthstring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvaluestring")]
        public string Defaultvaluestring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultvalueoptionset_value")]
        public string _defaultvalueoptionsetValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultvaluedecimal")]
        public decimal? Defaultvaluedecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public bool? Ishidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isrequired")]
        public bool? Isrequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public string Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minvalueinteger")]
        public int? Minvalueinteger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minvaluedouble")]
        public decimal? Minvaluedouble { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datatype")]
        public int? Datatype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxvaluedecimal")]
        public decimal? Maxvaluedecimal { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DynamicpropertySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DynamicpropertyAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DynamicpropertyMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DynamicpropertyBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DynamicpropertyPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "basedynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Basedynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicproperty_base_dynamicproperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> DynamicpropertyBaseDynamicproperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetvalueid")]
        public MicrosoftDynamicsCRMdynamicpropertyoptionsetitem Dynamicpropertyoptionsetvalueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Dynamicproperty_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> DynamicpropertyDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DynamicProperty_DynamicPropertyInstance")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyinstance> DynamicPropertyDynamicPropertyInstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DynamicProperty_DynamicPropertyOptionSetItem")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem> DynamicPropertyDynamicPropertyOptionSetItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_product")]
        public MicrosoftDynamicsCRMproduct RegardingobjectidProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_productassociation")]
        public MicrosoftDynamicsCRMproductassociation RegardingobjectidProductassociation { get; set; }

    }
}
