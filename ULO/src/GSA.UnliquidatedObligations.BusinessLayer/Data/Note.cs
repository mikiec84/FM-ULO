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
    
    public partial class Note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Note()
        {
            this.Notes1 = new HashSet<Note>();
        }
    
        public int NoteId { get; set; }
        public Nullable<int> ParentNoteId { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string NoteContents { get; set; }
        public int UloId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes1 { get; set; }
        public virtual Note Note1 { get; set; }
        public virtual UnliquidatedObligation UnliquidatedObligation { get; set; }
    }
}
