//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebOrders.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public receipt()
        {
            this.detailReceipts = new HashSet<detailReceipt>();
        }
    
        public string idReceipt { get; set; }
        public string idAccountant { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public Nullable<int> totalPrice { get; set; }
    
        public virtual accountant accountant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detailReceipt> detailReceipts { get; set; }
    }
}
