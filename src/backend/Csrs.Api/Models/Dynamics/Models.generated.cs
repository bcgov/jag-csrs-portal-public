using System;
using System.Text.Json.Serialization;

#nullable enable

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

    /// <summary></summary>
    public partial class File : Entity
    {
        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [JsonPropertyName("createdon")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Exchange rate for the currency associated with the entity with respect to the base currency.
        /// </summary>
        [JsonPropertyName("exchangerate")]
        public decimal? ExchangeRate { get; set; }
        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [JsonPropertyName("modifiedon")]
        public DateTime? ModifiedOn { get; set; }
        /// <summary>
        /// Auto Number to be copied to File Number. Do not delete
        /// </summary>
        [JsonPropertyName("ssg_autonumber")]
        public string? AutoNumber { get; set; }
        /// <summary>
        /// Select the level of court to filter the list of courts in the "Court Location" field.
        /// </summary>
        [JsonPropertyName("ssg_bccourtlevel")]
        public EntityReference? BCCourtLevel { get; set; }
        /// <summary>
        /// Select the BC Court registry for this File
        /// </summary>
        [JsonPropertyName("ssg_bccourtlocation")]
        public EntityReference? BCCourtLocation { get; set; }
        /// <summary>
        /// Enter the amount for child support as specified on the order/WA.
        /// </summary>
        [JsonPropertyName("ssg_childsupportonorder")]
        public Money? ChildSupportonOrder { get; set; }
        /// <summary>
        /// Value of the Child Support on Order in base currency.
        /// </summary>
        [JsonPropertyName("ssg_childsupportonorder_base")]
        public Money? childsupportonorder_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_courtfilenumber")]
        public string? CourtFileNumber { get; set; }
        /// <summary>
        /// Specify the court that executed the Court Order or Written Agreement. Defaulted to "Kelowna".
        /// </summary>
        [JsonPropertyName("ssg_courtlocation")]
        public string? CourtLocation { get; set; }
        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [JsonPropertyName("ssg_csrsfileid")]
        public System.Guid? CsrsFileId { get; set; }
        /// <summary>
        /// Enter the date the Order or WA was issued.
        /// </summary>
        [JsonPropertyName("ssg_dateoforderorwa")]
        public DateTime? DateofOrderorWA { get; set; }
        /// <summary>
        /// Specify the order commencement date.
        /// </summary>
        [JsonPropertyName("ssg_dateordercommences")]
        public DateTime? DateOrderCommences { get; set; }
        /// <summary>
        /// The number ID for the file record.
        /// </summary>
        [JsonPropertyName("ssg_filenumber")]
        public string? FileNumber { get; set; }
        /// <summary>
        /// Indicate whether the FMEP File is active or not.
        /// </summary>
        [JsonPropertyName("ssg_fmepfileactive")]
        public bool? FMEPFileActive { get; set; }
        /// <summary>
        /// Enter ID of the FMEP file number corresponding to this file.
        /// </summary>
        [JsonPropertyName("ssg_fmepfilenumber")]
        public string? FMEPFileNumber { get; set; }
        /// <summary>
        /// Enter the income as specified on the Order/WA
        /// </summary>
        [JsonPropertyName("ssg_incomeonorder")]
        public Money? IncomeonOrder { get; set; }
        /// <summary>
        /// Value of the Income on Order in base currency.
        /// </summary>
        [JsonPropertyName("ssg_incomeonorder_base")]
        public Money? incomeonorder_Base { get; set; }
        /// <summary>
        /// Enter the Payor's income from three years ago (example: for order made in 2021, enter income from 2018 here).
        /// </summary>
        [JsonPropertyName("ssg_incomeyear1")]
        public Money? IncomeYear1 { get; set; }
        /// <summary>
        /// Value of the Income - Year 1 in base currency.
        /// </summary>
        [JsonPropertyName("ssg_incomeyear1_base")]
        public Money? incomeyear1_Base { get; set; }
        /// <summary>
        /// Enter payor's income from two years ago to calculate the CS from the pattern of income. Example: if order is made in 2021, enter 2019 income here.
        /// </summary>
        [JsonPropertyName("ssg_incomeyear2")]
        public Money? IncomeYear2 { get; set; }
        /// <summary>
        /// Value of the Income - Year 2 in base currency.
        /// </summary>
        [JsonPropertyName("ssg_incomeyear2_base")]
        public Money? incomeyear2_Base { get; set; }
        /// <summary>
        /// Enter the Payor's income from last year to calculate the CS from pattern of income, Example: if order was made in 2021, enter 2020 income here.
        /// </summary>
        [JsonPropertyName("ssg_incomeyear3")]
        public Money? IncomeYear3 { get; set; }
        /// <summary>
        /// Value of the Income - Year 3 in base currency.
        /// </summary>
        [JsonPropertyName("ssg_incomeyear3_base")]
        public Money? incomeyear3_Base { get; set; }
        /// <summary>
        /// Number of Recalculations for the File - Used for numbering File's Recalculations.
        /// </summary>
        [JsonPropertyName("ssg_numberofrecalculations")]
        public int? NumberofRecalculations { get; set; }
        /// <summary>
        /// Difference in CS on order payable by Payor and by Recipient.
        /// </summary>
        [JsonPropertyName("ssg_offsetchildsupportamountonorder")]
        public Money? OffsetChildSupportAmountonOrder { get; set; }
        /// <summary>
        /// Value of the Offset Child Support Amount on Order in base currency.
        /// </summary>
        [JsonPropertyName("ssg_offsetchildsupportamountonorder_base")]
        public Money? offsetchildsupportamountonorder_Base { get; set; }
        /// <summary>
        /// Select the party who provides (pays for) support.
        /// </summary>
        [JsonPropertyName("ssg_payor")]
        public EntityReference? Payor { get; set; }
        /// <summary>
        /// Indicate whether the Recalculation was ordered by the court.
        /// </summary>
        [JsonPropertyName("ssg_recalculationorderedbythecourt")]
        public bool? RecalculationOrderedbytheCourt { get; set; }
        /// <summary>
        /// Select the party who receives support.
        /// </summary>
        [JsonPropertyName("ssg_recipient")]
        public EntityReference? Recipient { get; set; }
        /// <summary>
        /// Enter the child support amount for Recipient as specified on the Order/WA.
        /// </summary>
        [JsonPropertyName("ssg_recipientschildsupportonorder")]
        public Money? RecipientsChildSupportonOrder { get; set; }
        /// <summary>
        /// Value of the Recipient's Child Support on Order in base currency.
        /// </summary>
        [JsonPropertyName("ssg_recipientschildsupportonorder_base")]
        public Money? recipientschildsupportonorder_Base { get; set; }
        /// <summary>
        /// System-set indicator to allow capture of Recipient's Income on Recalculations
        /// </summary>
        [JsonPropertyName("ssg_recipientsincomeneeded")]
        public bool? RecipientsIncomeNeeded { get; set; }
        /// <summary>
        /// Enter the Recipient's income as specified on the Order/WA.
        /// </summary>
        [JsonPropertyName("ssg_recipientsincomeonorder")]
        public Money? RecipientsIncomeonOrder { get; set; }
        /// <summary>
        /// Value of the Recipient's Income on Order in base currency.
        /// </summary>
        [JsonPropertyName("ssg_recipientsincomeonorder_base")]
        public Money? recipientsincomeonorder_Base { get; set; }
        /// <summary>
        /// The registration date of the CSRS file.
        /// </summary>
        [JsonPropertyName("ssg_registrationdate")]
        public DateTime? RegistrationDate { get; set; }
        /// <summary>
        /// Indicate whether there is a Safety Alert applies to the file
        /// </summary>
        [JsonPropertyName("ssg_safetyalert")]
        public bool? SafetyAlert { get; set; }
        /// <summary>
        /// Description of the Safety Concerns
        /// </summary>
        [JsonPropertyName("ssg_safetyconcerndescription")]
        public string? SafetyConcernDescription { get; set; }
        /// <summary>
        /// Indicate whether the Section 7 expenses will be recalculated for the File.
        /// </summary>
        [JsonPropertyName("ssg_section7expensesrecalculated")]
        public bool? Section7ExpensesRecalculated { get; set; }
        /// <summary>
        /// Amount of special expenses payable by the Payor.
        /// </summary>
        [JsonPropertyName("ssg_section7payorsamount")]
        public Money? Section7PayorsAmount { get; set; }
        /// <summary>
        /// Value of the Section 7 Payor's Amount in base currency.
        /// </summary>
        [JsonPropertyName("ssg_section7payorsamount_base")]
        public Money? section7payorsamount_Base { get; set; }
        /// <summary>
        /// Percentage of Section 7 Expenses payable by the Payor.
        /// </summary>
        [JsonPropertyName("ssg_section7payorsproportion")]
        public int? Section7PayorsProportion { get; set; }
        /// <summary>
        /// Amount of special expenses payable by the Recipient.
        /// </summary>
        [JsonPropertyName("ssg_section7recipientsamount")]
        public Money? Section7RecipientsAmount { get; set; }
        /// <summary>
        /// Value of the Section 7 Recipient's Amount in base currency.
        /// </summary>
        [JsonPropertyName("ssg_section7recipientsamount_base")]
        public Money? section7recipientsamount_Base { get; set; }
        /// <summary>
        /// Percentage of Section 7 Expenses payable by the Recipient
        /// </summary>
        [JsonPropertyName("ssg_section7recipientsproportion")]
        public int? Section7RecipientsProportion { get; set; }
        /// <summary>
        /// Total Amount of special expenses for the Court File.
        /// </summary>
        [JsonPropertyName("ssg_section7totalamount")]
        public Money? Section7TotalAmount { get; set; }
        /// <summary>
        /// Value of the Section 7 Total Amount in base currency.
        /// </summary>
        [JsonPropertyName("ssg_section7totalamount_base")]
        public Money? section7totalamount_Base { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_sharedparenting")]
        public bool? SharedParenting { get; set; }
        /// <summary>
        /// Date when Section 7 Expenses were withdrawn.
        /// </summary>
        [JsonPropertyName("ssg_specialexpenseswithdrawndate")]
        public DateTime? SpecialExpensesWithdrawnDate { get; set; }
        /// <summary>
        /// Specify whether the parents are sharing custody (parenting) of the child(ren).
        /// </summary>
        [JsonPropertyName("ssg_splitparentingarrangement")]
        public bool? SplitParentingArrangement { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_styleofcauseapplicant")]
        public string? StyleofCauseApplicant { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_styleofcauserespondent")]
        public string? StyleofCauseRespondent { get; set; }
        /// <summary>
        /// Date/time the application or file was first submitted to the Program.
        /// </summary>
        [JsonPropertyName("ssg_submissiondate")]
        public DateTime? SubmissionDate { get; set; }
        /// <summary>
        /// Date when the File's state is set to "Inactive".
        /// </summary>
        [JsonPropertyName("ssg_terminationdate")]
        public DateTime? TerminationDate { get; set; }
        /// <summary>
        /// Unique identifier of the currency associated with the entity.
        /// </summary>
        [JsonPropertyName("transactioncurrencyid")]
        public EntityReference? TransactionCurrencyId { get; set; }
    }

    /// <summary>
    /// Child Support Recalculation System parties
    /// </summary>
    public partial class Party : Entity
    {
        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [JsonPropertyName("createdon")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [JsonPropertyName("modifiedon")]
        public DateTime? ModifiedOn { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_areapostalcode")]
        public string? PostalCode { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_bceid_displayname")]
        public string? BCeIDDisplayName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_bceid_guid")]
        public string? BCeIDGuid { get; set; }
        /// <summary>
        /// Timestamp for the last update of BCeID GUID
        /// </summary>
        [JsonPropertyName("ssg_bceid_last_update")]
        public DateTime? BCeID_Last_Update { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_bceid_userid")]
        public string? BCeID_UserId { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_cellphone")]
        public string? CellPhone { get; set; }
        /// <summary>
        /// Party's city of residence.
        /// </summary>
        [JsonPropertyName("ssg_city")]
        public string? City { get; set; }
        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [JsonPropertyName("ssg_csrspartyid")]
        public System.Guid? PartyId { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_dateofbirth")]
        public DateTime? DateofBirth { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_email")]
        public string? Email { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_firstname")]
        public string? FirstName { get; set; }
        /// <summary>
        /// The full name of the party.
        /// </summary>
        [JsonPropertyName("ssg_fullname")]
        public string? FullName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_homephone")]
        public string? HomePhone { get; set; }
        /// <summary>
        /// Capture "Other" details regarding the Party's Identity
        /// </summary>
        [JsonPropertyName("ssg_identityotherdetails")]
        public string? IdentityOtherDetails { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_lastname")]
        public string? LastName { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_middlename")]
        public string? MiddleName { get; set; }
        /// <summary>
        /// Determines If the user access is enabled or disabled to the portal
        /// </summary>
        [JsonPropertyName("ssg_portalaccess")]
        public bool? PortalAccess { get; set; }
        /// <summary>
        /// Enter the preferred name for the Party.
        /// </summary>
        [JsonPropertyName("ssg_preferredname")]
        public string? PreferredName { get; set; }
        /// <summary>
        /// to be deleted
        /// </summary>
        [JsonPropertyName("ssg_stagingfilenumber")]
        public int? StagingFileNumber { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_stagingid")]
        public int? StagingId { get; set; }
        /// <summary>
        /// First line of the Party's street address.
        /// </summary>
        [JsonPropertyName("ssg_street1")]
        public string? AddressStreet1 { get; set; }
        /// <summary>
        /// Additional details for the Party's street address (for unit #, floor, buzzer #, etc)
        /// </summary>
        [JsonPropertyName("ssg_street2")]
        public string? AddressStreet2 { get; set; }
        /// <summary></summary>
        [JsonPropertyName("ssg_workphone")]
        public string? WorkPhone { get; set; }
    }
}
