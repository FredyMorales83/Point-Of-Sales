//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Point_Of_Sales
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.Products = new HashSet<Product>();
        }
    
        public string Supplier_Id { get; set; }
        public string Supplier_Name { get; set; }
        public string Supplier_Email { get; set; }
        public Nullable<decimal> Supplier_Phone_no { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
