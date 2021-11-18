using System;
using System.Text.Json.Serialization;

namespace Csrs.Api.Models.Dynamics
{
    public abstract class Entity
    {
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }
    }
    public class EntityReference
    {
        public EntityReference()
        {
        }
        public EntityReference(string logicalName, Guid id)
        {
            LogicalName = logicalName;
            Id = id;
        }
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("logicalName")]
        public string LogicalName { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("rowVersion")]
        public string RowVersion { get; set; }
    }
    public class Money
    {
        [JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public partial class File : Entity
    {
        /// <summary></summary>
        [JsonPropertyName("createdby")]
        public EntityReference? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdbyname")]
        public string? CreatedByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdbyyominame")]
        public string? CreatedByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("createdon")]
        public DateTime? CreatedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("createdonbehalfby")]
        public EntityReference? CreatedOnBehalfBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdonbehalfbyname")]
        public string? CreatedOnBehalfByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdonbehalfbyyominame")]
        public string? CreatedOnBehalfByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("exchangerate")]
        public decimal? ExchangeRate { get; set; }
        /// <summary></summary>
        [JsonPropertyName("importsequencenumber")]
        public int? ImportSequenceNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("modifiedby")]
        public EntityReference? ModifiedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedbyname")]
        public string? ModifiedByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedbyyominame")]
        public string? ModifiedByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("modifiedon")]
        public DateTime? ModifiedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("modifiedonbehalfby")]
        public EntityReference? ModifiedOnBehalfBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedonbehalfbyname")]
        public string? ModifiedOnBehalfByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedonbehalfbyyominame")]
        public string? ModifiedOnBehalfByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ownerid")]
        public EntityReference? OwnerId { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owneridname")]
        public string? OwnerIdName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owneridtype")]
        public string? OwnerIdType { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owneridyominame")]
        public string? OwnerIdYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owningbusinessunit")]
        public EntityReference? OwningBusinessUnit { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owningteam")]
        public EntityReference? OwningTeam { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owninguser")]
        public EntityReference? OwningUser { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_autonumber")]
        public string? AutoNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_bccourtlevel")]
        public EntityReference? BCCourtLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_bccourtlevelname")]
        public string? BCCourtLevelName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_bccourtlocation")]
        public EntityReference? BCCourtLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_bccourtlocationname")]
        public string? BCCourtLocationName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_childsupportonorder")]
        public Money? ChildSupportonOrder { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_childsupportonorder_base")]
        public Money? childsupportonorder_Base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_courtfilenumber")]
        public string? CourtFileNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_courtlocation")]
        public string? CourtLocation { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_csrsfileid")]
        public System.Guid? csrsfileId { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_dateoforderorwa")]
        public DateTime? DateofOrderorWA { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_dateordercommences")]
        public DateTime? DateOrderCommences { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_filenumber")]
        public string? FileNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_fmepfileactive")]
        public bool? FMEPFileActive { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_fmepfilenumber")]
        public string? FMEPFileNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeonorder")]
        public Money? IncomeonOrder { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeonorder_base")]
        public Money? incomeonorder_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeyear1")]
        public Money? IncomeYear1 { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeyear1_base")]
        public Money? incomeyear1_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeyear2")]
        public Money? IncomeYear2 { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeyear2_base")]
        public Money? incomeyear2_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeyear3")]
        public Money? IncomeYear3 { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_incomeyear3_base")]
        public Money? incomeyear3_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_numberofrecalculations")]
        public int? NumberofRecalculations { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_offsetchildsupportamountonorder")]
        public Money? OffsetChildSupportAmountonOrder { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_offsetchildsupportamountonorder_base")]
        public Money? offsetchildsupportamountonorder_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_payor")]
        public EntityReference? Payor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_payorname")]
        public string? PayorName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recalculationorderedbythecourt")]
        public bool? RecalculationOrderedbytheCourt { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recipient")]
        public EntityReference? Recipient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_recipientname")]
        public string? RecipientName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recipientschildsupportonorder")]
        public Money? RecipientsChildSupportonOrder { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recipientschildsupportonorder_base")]
        public Money? recipientschildsupportonorder_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recipientsincomeneeded")]
        public bool? RecipientsIncomeNeeded { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recipientsincomeonorder")]
        public Money? RecipientsIncomeonOrder { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_recipientsincomeonorder_base")]
        public Money? recipientsincomeonorder_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_registrationdate")]
        public DateTime? RegistrationDate { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_safetyalert")]
        public bool? SafetyAlert { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_safetyconcerndescription")]
        public string? SafetyConcernDescription { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7expensesrecalculated")]
        public bool? Section7ExpensesRecalculated { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7payorsamount")]
        public Money? Section7PayorsAmount { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7payorsamount_base")]
        public Money? section7payorsamount_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7payorsproportion")]
        public int? Section7PayorsProportion { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7recipientsamount")]
        public Money? Section7RecipientsAmount { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7recipientsamount_base")]
        public Money? section7recipientsamount_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7recipientsproportion")]
        public int? Section7RecipientsProportion { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7totalamount")]
        public Money? Section7TotalAmount { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_section7totalamount_base")]
        public Money? section7totalamount_base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_sharedparenting")]
        public bool? SharedParenting { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_specialexpenseswithdrawndate")]
        public DateTime? SpecialExpensesWithdrawnDate { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_splitparentingarrangement")]
        public bool? SplitParentingArrangement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_styleofcauseapplicant")]
        public string? StyleofCauseApplicant { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_styleofcauserespondent")]
        public string? StyleofCauseRespondent { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_submissiondate")]
        public DateTime? SubmissionDate { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_terminationdate")]
        public DateTime? TerminationDate { get; set; }
        /// <summary></summary>
        [JsonPropertyName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("transactioncurrencyid")]
        public EntityReference? TransactionCurrencyId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transactioncurrencyidname")]
        public string? TransactionCurrencyIdName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode { get; set; }
        /// <summary></summary>
        [JsonPropertyName("versionnumber")]
        public long? VersionNumber { get; set; }
    }
    /// <summary>
    /// Child Support Recalculation System parties
    /// </summary>
    public partial class Party : Entity
    {
        /// <summary></summary>
        [JsonPropertyName("createdby")]
        public EntityReference? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdbyname")]
        public string? CreatedByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdbyyominame")]
        public string? CreatedByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("createdon")]
        public DateTime? CreatedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("createdonbehalfby")]
        public EntityReference? CreatedOnBehalfBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdonbehalfbyname")]
        public string? CreatedOnBehalfByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("createdonbehalfbyyominame")]
        public string? CreatedOnBehalfByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("importsequencenumber")]
        public int? ImportSequenceNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("modifiedby")]
        public EntityReference? ModifiedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedbyname")]
        public string? ModifiedByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedbyyominame")]
        public string? ModifiedByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("modifiedon")]
        public DateTime? ModifiedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("modifiedonbehalfby")]
        public EntityReference? ModifiedOnBehalfBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedonbehalfbyname")]
        public string? ModifiedOnBehalfByName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("modifiedonbehalfbyyominame")]
        public string? ModifiedOnBehalfByYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ownerid")]
        public EntityReference? OwnerId { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owneridname")]
        public string? OwnerIdName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owneridtype")]
        public string? OwnerIdType { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owneridyominame")]
        public string? OwnerIdYomiName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owningbusinessunit")]
        public EntityReference? OwningBusinessUnit { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owningteam")]
        public EntityReference? OwningTeam { get; set; }
        /// <summary></summary>
        [JsonPropertyName("owninguser")]
        public EntityReference? OwningUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_areapostalcode")]
        public string? AreaPostalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_bceid_displayname")]
        public string? BCeID_DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_bceid_guid")]
        public string? BCeID_Guid { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_bceid_last_update")]
        public DateTime? BCeID_Last_Update { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_bceid_userid")]
        public string? BCeID_UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_cellphone")]
        public string? CellPhone { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_city")]
        public string? City { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_csrspartyid")]
        public System.Guid? csrspartyId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_dateofbirth")]
        public DateTime? DateofBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_email")]
        public string? Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_firstname")]
        public string? FirstName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_fullname")]
        public string? FullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_homephone")]
        public string? HomePhone { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_identityotherdetails")]
        public string? IdentityOtherDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_lastname")]
        public string? LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_middlename")]
        public string? MiddleName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_portalaccess")]
        public bool? PortalAccess { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_preferredname")]
        public string? PreferredName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_stagingfilenumber")]
        public int? StagingFileNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_stagingid")]
        public int? StagingId { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_street1")]
        public string? Street1 { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_street2")]
        public string? Street2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ssg_workphone")]
        public string? WorkPhone { get; set; }
        /// <summary></summary>
        [JsonPropertyName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode { get; set; }
        /// <summary></summary>
        [JsonPropertyName("versionnumber")]
        public long? VersionNumber { get; set; }
    }
}
