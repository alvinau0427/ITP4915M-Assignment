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
    
    public partial class equipment
    {
        public equipment()
        {
            this.equipmentlist = new HashSet<equipmentlist>();
        }
    
        public string EquipID { get; set; }
        public string Equipment1 { get; set; }
        public string Suitable { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string EquipPhoto { get; set; }
    
        public virtual ICollection<equipmentlist> equipmentlist { get; set; }
    }
}
