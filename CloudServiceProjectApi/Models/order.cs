//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudServiceProjectApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.orderdetails = new HashSet<orderdetail>();
        }
    
        public int orderNumber { get; set; }
        public System.DateTime orderDate { get; set; }
        public System.DateTime requiredDate { get; set; }
        public Nullable<System.DateTime> shippedDate { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
        public int customerNumber { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderdetail> orderdetails { get; set; }
    }
}
