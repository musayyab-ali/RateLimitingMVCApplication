//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RateLimitWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artical_Tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artical_Tbl()
        {
            this.Comment_Tbl = new HashSet<Comment_Tbl>();
        }
    
        public int ArticalId { get; set; }
        public string ArticalName { get; set; }
        public string ArticalDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment_Tbl> Comment_Tbl { get; set; }
    }
}
