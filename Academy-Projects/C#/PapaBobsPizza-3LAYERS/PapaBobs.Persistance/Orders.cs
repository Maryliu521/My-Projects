//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PapaBobs.Persistance
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public System.Guid OrderId { get; set; }
        public PapaBobs.DTO.Enums.SizeType Size { get; set; }
        public PapaBobs.DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public PapaBobs.DTO.Enums.PaymentType Payment { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Completed { get; set; }
    }
}