//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime FinishDate { get; set; }
        public Nullable<System.DateTime> Returned { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
