//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenItems.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblReviewFeedback
    {
        public int LoadID { get; set; }
        public string DocNumber { get; set; }
        public int OriginalItemID { get; set; }
        public string FeedbackComments { get; set; }
        public int Valid { get; set; }
        public string Response { get; set; }
        public Nullable<decimal> DOShouldBe { get; set; }
        public Nullable<decimal> UDOShouldBe { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}
