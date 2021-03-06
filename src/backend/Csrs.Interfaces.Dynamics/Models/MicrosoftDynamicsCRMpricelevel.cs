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
    /// Microsoft.Dynamics.CRM.pricelevel
    /// </summary>
    public partial class MicrosoftDynamicsCRMpricelevel
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpricelevel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpricelevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpricelevel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpricelevel(string _createdbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string description = default(string), string versionnumber = default(string), string pricelevelid = default(string), int? shippingmethodcode = default(int?), string _organizationidValue = default(string), int? statuscode = default(int?), string name = default(string), int? statecode = default(int?), int? freighttermscode = default(int?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? paymentmethodcode = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? enddate = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), System.DateTimeOffset? begindate = default(System.DateTimeOffset?), decimal? exchangerate = default(decimal?), string _transactioncurrencyidValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> priceLevelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> priceLevelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> pricelevelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> priceLevelProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> priceLevelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> pricelevelPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> pricelevelConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> pricelevelConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMproductpricelevel> priceLevelProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMaccount> priceLevelAccounts = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMcontact> priceLevelContacts = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMproduct> priceLevelProducts = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMcampaign> priceListCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMinvoice> priceLevelInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMopportunity> priceLevelOpportunties = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMsalesorder> priceLevelOrders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMquote> priceLevelQuotes = default(IList<MicrosoftDynamicsCRMquote>))
        {
            this._createdbyValue = _createdbyValue;
            Overriddencreatedon = overriddencreatedon;
            Description = description;
            Versionnumber = versionnumber;
            Pricelevelid = pricelevelid;
            Shippingmethodcode = shippingmethodcode;
            this._organizationidValue = _organizationidValue;
            Statuscode = statuscode;
            Name = name;
            Statecode = statecode;
            Freighttermscode = freighttermscode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Paymentmethodcode = paymentmethodcode;
            this._modifiedbyValue = _modifiedbyValue;
            Enddate = enddate;
            Importsequencenumber = importsequencenumber;
            Begindate = begindate;
            Exchangerate = exchangerate;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            PriceLevelSyncErrors = priceLevelSyncErrors;
            PriceLevelAsyncOperations = priceLevelAsyncOperations;
            PricelevelMailboxTrackingFolders = pricelevelMailboxTrackingFolders;
            PriceLevelProcessSessions = priceLevelProcessSessions;
            PriceLevelBulkDeleteFailures = priceLevelBulkDeleteFailures;
            PricelevelPrincipalobjectattributeaccess = pricelevelPrincipalobjectattributeaccess;
            PricelevelConnections1 = pricelevelConnections1;
            PricelevelConnections2 = pricelevelConnections2;
            PriceLevelProductPriceLevels = priceLevelProductPriceLevels;
            PriceLevelAccounts = priceLevelAccounts;
            PriceLevelContacts = priceLevelContacts;
            PriceLevelProducts = priceLevelProducts;
            Transactioncurrencyid = transactioncurrencyid;
            PriceListCampaigns = priceListCampaigns;
            PriceLevelInvoices = priceLevelInvoices;
            PriceLevelOpportunties = priceLevelOpportunties;
            PriceLevelOrders = priceLevelOrders;
            PriceLevelQuotes = priceLevelQuotes;
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
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public string Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentmethodcode")]
        public int? Paymentmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "begindate")]
        public System.DateTimeOffset? Begindate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PriceLevelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PriceLevelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> PricelevelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> PriceLevelProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceLevel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PriceLevelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PricelevelPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> PricelevelConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevel_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> PricelevelConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> PriceLevelProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_accounts")]
        public IList<MicrosoftDynamicsCRMaccount> PriceLevelAccounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_contacts")]
        public IList<MicrosoftDynamicsCRMcontact> PriceLevelContacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_products")]
        public IList<MicrosoftDynamicsCRMproduct> PriceLevelProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PriceList_Campaigns")]
        public IList<MicrosoftDynamicsCRMcampaign> PriceListCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> PriceLevelInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_opportunties")]
        public IList<MicrosoftDynamicsCRMopportunity> PriceLevelOpportunties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_orders")]
        public IList<MicrosoftDynamicsCRMsalesorder> PriceLevelOrders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_level_quotes")]
        public IList<MicrosoftDynamicsCRMquote> PriceLevelQuotes { get; set; }

    }
}
