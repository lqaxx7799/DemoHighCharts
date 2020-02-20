//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoHighCharts.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuItem()
        {
            this.DirectOrderDetails = new HashSet<DirectOrderDetail>();
        }
    
        public int Id { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> MenuCategoryId { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Sale_Amount { get; set; }
        public string Status { get; set; }
        public string Recipe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirectOrderDetail> DirectOrderDetails { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}
