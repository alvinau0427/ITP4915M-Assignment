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
    
    public partial class vehiclebooking
    {
        public vehiclebooking()
        {
            this.driverbooking = new HashSet<driverbooking>();
            this.equipmentlist = new HashSet<equipmentlist>();
        }
    
        public int VehicleBookingID { get; set; }
        public string VehicleID { get; set; }
        public Nullable<int> AttractionBookingID { get; set; }
        public Nullable<int> BookDay { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string OrderBy { get; set; }
        public Nullable<System.DateTime> PickupDate { get; set; }
        public Nullable<System.DateTime> DropoffDate { get; set; }
        public Nullable<decimal> DriverCost { get; set; }
        public Nullable<decimal> VehicleBookPrice { get; set; }
    
        public virtual attractionbooking attractionbooking { get; set; }
        public virtual ICollection<driverbooking> driverbooking { get; set; }
        public virtual ICollection<equipmentlist> equipmentlist { get; set; }
        public virtual staff staff { get; set; }
        public virtual vehicle vehicle { get; set; }
    }
}