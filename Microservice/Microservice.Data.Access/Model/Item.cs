//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microservice.Data.Access.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.TransactionItems = new HashSet<TransactionItem>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public System.DateTimeOffset CreateDate { get; set; }
        public System.DateTimeOffset UpdateDate { get; set; }
        public System.DateTimeOffset DeleteDate { get; set; }
        public bool IsDelete { get; set; }
        public int Stock { get; set; }
        public Nullable<int> Suppliers_Id { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionItem> TransactionItems { get; set; }
    }
}
