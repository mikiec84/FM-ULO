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
    
    public partial class Review
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Review()
        {
            this.UnliquidatedObligations = new HashSet<UnliquidatedObligation>();
        }
    
        public Nullable<int> RegionId { get; set; }
        public string ReviewName { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int ReviewId { get; set; }
        public System.DateTime CreatedAtUtc { get; set; }
        public int ReviewTypeId { get; set; }
        public int ReviewScopeId { get; set; }
        public int WorkflowDefinitionId { get; set; }
        public Nullable<System.DateTime> ProjectDueDate { get; set; }
        public Nullable<System.DateTime> ReviewDateInitiated { get; set; }
        public bool IsClosed { get; set; }
        public string DeletedByUserId { get; set; }
    
        public virtual Region Region { get; set; }
        public virtual Region Region1 { get; set; }
        public virtual WorkflowDefinition WorkflowDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnliquidatedObligation> UnliquidatedObligations { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
