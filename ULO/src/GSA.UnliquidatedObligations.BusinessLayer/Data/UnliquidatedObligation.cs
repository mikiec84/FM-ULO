//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSA.UnliquidatedObligations.BusinessLayer.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnliquidatedObligation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnliquidatedObligation()
        {
            this.Notes = new HashSet<Note>();
            this.Workflows = new HashSet<Workflow>();
        }
    
        public int UloId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public int ReviewId { get; set; }
        public string Organization { get; set; }
        public string Fund { get; set; }
        public string Prog { get; set; }
        public string DocType { get; set; }
        public string PegasysDocumentNumber { get; set; }
        public string PegasysTitleNumber { get; set; }
        public string BBFY { get; set; }
        public string EBFY { get; set; }
        public string Acty { get; set; }
        public string SOC { get; set; }
        public string Project { get; set; }
        public string Agreement { get; set; }
        public string ContractNum { get; set; }
        public string Bldg { get; set; }
        public string SysLoc { get; set; }
        public string VehTag { get; set; }
        public Nullable<int> WI { get; set; }
        public string LeaseNumber { get; set; }
        public string VendorName { get; set; }
        public string ActgPd { get; set; }
        public string TAFS { get; set; }
        public string DUNSNum { get; set; }
        public Nullable<int> DaysSinceLastActivity { get; set; }
        public Nullable<int> DaysSinceFirstActivity { get; set; }
        public string TradingPartnerType { get; set; }
        public string VendorAgencyCode { get; set; }
        public string VendorBureauCode { get; set; }
        public Nullable<bool> Valid { get; set; }
        public string Status { get; set; }
        public string AwardNbr { get; set; }
        public string ContractingOfficersName { get; set; }
        public string ReasonIncludedInReview { get; set; }
        public string EASi_Base_Contract_Nbr { get; set; }
        public string EASi_GSA_FSS_Other__ { get; set; }
        public Nullable<System.DateTime> ExpectedDateForCompletion { get; set; }
        public Nullable<decimal> TotalLine { get; set; }
        public Nullable<decimal> Commitments { get; set; }
        public Nullable<decimal> Prepayments { get; set; }
        public Nullable<decimal> UndelOrders { get; set; }
        public Nullable<decimal> Rcpt { get; set; }
        public Nullable<decimal> Accrual { get; set; }
        public Nullable<decimal> TotalDO { get; set; }
        public Nullable<decimal> TotalUDOAndDO { get; set; }
        public Nullable<decimal> PendPayments { get; set; }
        public Nullable<decimal> PymtsInTransit { get; set; }
        public Nullable<decimal> PymtsConfirmed { get; set; }
        public Nullable<decimal> Holdbacks { get; set; }
        public Nullable<System.DateTime> DateOfLastActivity { get; set; }
        public Nullable<System.DateTime> DateOfFirstActivity { get; set; }
        public Nullable<System.DateTime> RWACompletionDate { get; set; }
        public Nullable<System.DateTime> EASiAwdExpirationDate { get; set; }
        public Nullable<int> ItemsLineNumber { get; set; }
        public Nullable<int> AccountingLineNumber { get; set; }
        public Nullable<int> OC { get; set; }
        public string ContractingOfficerEmail { get; set; }
        public string ContractingSpecialistName { get; set; }
        public string ContractingSpecialistEmail { get; set; }
        public string BudgetAnalystEmail { get; set; }
        public Nullable<bool> C_Temp { get; set; }
        public string CardholderName { get; set; }
        public string CardholderAlias8 { get; set; }
        public string CardholderAlias { get; set; }
        public string CardholderEmail { get; set; }
        public string CardholderUserId { get; set; }
        public Nullable<int> PegasysDocumentNumberInstance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
        public virtual Review Review { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workflow> Workflows { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
