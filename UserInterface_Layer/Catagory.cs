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
    
    public partial class Catagory
    {
        public Catagory()
        {
            this.Products = new HashSet<Product>();
        }
    
        public string Catagory_Id { get; set; }
        public string Catagory_Name { get; set; }
        public string Catagory_unit_Measure { get; set; }
        public string Catagory_Description { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}