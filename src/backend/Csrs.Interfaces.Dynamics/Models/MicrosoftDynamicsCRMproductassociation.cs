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
    /// Microsoft.Dynamics.CRM.productassociation
    /// </summary>
    public partial class MicrosoftDynamicsCRMproductassociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMproductassociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMproductassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMproductassociation(string _createdbyValue = default(string), int? statecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string productassociationid = default(string), string _modifiedbyValue = default(string), decimal? quantity = default(decimal?), string _productidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), decimal? exchangerate = default(decimal?), int? statuscode = default(int?), string _transactioncurrencyidValue = default(string), int? timezoneruleversionnumber = default(int?), int? importsequencenumber = default(int?), string _uomidValue = default(string), int? propertycustomizationstatus = default(int?), int? productisrequired = default(int?), int? dmtimportstate = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string versionnumber = default(string), string _associatedproductValue = default(string), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> productAssociationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> productAssociationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> productassociationMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> productAssociationProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> productassociationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> productAssociationPrincipalObjectAttributeAccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMproduct associatedproduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> productAssociationDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), IList<MicrosoftDynamicsCRMdynamicproperty> productAssociationDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMquotedetail> productAssociationQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMopportunityproduct> productAssociationOpportunityProduct = default(IList<MicrosoftDynamicsCRMopportunityproduct>), IList<MicrosoftDynamicsCRMinvoicedetail> productAssociationInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMsalesorderdetail> productAssociationSalesorderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>))
        {
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Overriddencreatedon = overriddencreatedon;
            Productassociationid = productassociationid;
            this._modifiedbyValue = _modifiedbyValue;
            Quantity = quantity;
            this._productidValue = _productidValue;
            Modifiedon = modifiedon;
            Exchangerate = exchangerate;
            Statuscode = statuscode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Importsequencenumber = importsequencenumber;
            this._uomidValue = _uomidValue;
            Propertycustomizationstatus = propertycustomizationstatus;
            Productisrequired = productisrequired;
            Dmtimportstate = dmtimportstate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Versionnumber = versionnumber;
            this._associatedproductValue = _associatedproductValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            ProductAssociationSyncErrors = productAssociationSyncErrors;
            ProductAssociationAsyncOperations = productAssociationAsyncOperations;
            ProductassociationMailboxTrackingFolders = productassociationMailboxTrackingFolders;
            ProductAssociationProcessSessions = productAssociationProcessSessions;
            ProductassociationBulkDeleteFailures = productassociationBulkDeleteFailures;
            ProductAssociationPrincipalObjectAttributeAccess = productAssociationPrincipalObjectAttributeAccess;
            Associatedproduct = associatedproduct;
            Productid = productid;
            ProductAssociationDynamicPropertyAssociation = productAssociationDynamicPropertyAssociation;
            ProductAssociationDynamicProperty = productAssociationDynamicProperty;
            Transactioncurrencyid = transactioncurrencyid;
            Uomid = uomid;
            ProductAssociationQuoteDetails = productAssociationQuoteDetails;
            ProductAssociationOpportunityProduct = productAssociationOpportunityProduct;
            ProductAssociationInvoiceDetails = productAssociationInvoiceDetails;
            ProductAssociationSalesorderDetails = productAssociationSalesorderDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociationid")]
        public string Productassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public string _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

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
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public string _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "propertycustomizationstatus")]
        public int? Propertycustomizationstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productisrequired")]
        public int? Productisrequired { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_associatedproduct_value")]
        public string _associatedproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductAssociationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductAssociationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociation_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ProductassociationMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ProductAssociationProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productassociation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ProductassociationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_PrincipalObjectAttributeAccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ProductAssociationPrincipalObjectAttributeAccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associatedproduct")]
        public MicrosoftDynamicsCRMproduct Associatedproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> ProductAssociationDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductAssociation_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> ProductAssociationDynamicProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> ProductAssociationQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_opportunity_product")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> ProductAssociationOpportunityProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> ProductAssociationInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productAssociation_salesorder_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> ProductAssociationSalesorderDetails { get; set; }

    }
}
