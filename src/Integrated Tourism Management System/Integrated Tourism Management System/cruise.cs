//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Integrated_Tourism_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class cruise
    {
        public cruise()
        {
            this.cruisebooking = new HashSet<cruisebooking>();
        }
    
        public string CruiseNo { get; set; }
        public string CruiseName { get; set; }
        public Nullable<decimal> RefPrice { get; set; }
        public Nullable<int> TourDay { get; set; }
        public Nullable<int> OrganID { get; set; }
        public string Info { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    
        public virtual corganizer corganizer { get; set; }
        public virtual ICollection<cruisebooking> cruisebooking { get; set; }
    }
}