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
    
    public partial class Attachment
    {
        public int AttachmentsId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> DocumentId { get; set; }
    
        public virtual Document Document { get; set; }
    }
}
