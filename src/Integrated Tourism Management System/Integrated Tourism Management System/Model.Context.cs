﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tickettailor_dbEntities : DbContext
    {
        public tickettailor_dbEntities()
            : base("name=tickettailor_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<attraction> attraction { get; set; }
        public DbSet<attractionbooking> attractionbooking { get; set; }
        public DbSet<attractionprice> attractionprice { get; set; }
        public DbSet<carrier> carrier { get; set; }
        public DbSet<corganizer> corganizer { get; set; }
        public DbSet<cruise> cruise { get; set; }
        public DbSet<cruisebooking> cruisebooking { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<driver> driver { get; set; }
        public DbSet<driverbooking> driverbooking { get; set; }
        public DbSet<driverroster> driverroster { get; set; }
        public DbSet<equipment> equipment { get; set; }
        public DbSet<equipmentlist> equipmentlist { get; set; }
        public DbSet<flightbooking> flightbooking { get; set; }
        public DbSet<flightclass> flightclass { get; set; }
        public DbSet<flightschedule> flightschedule { get; set; }
        public DbSet<hotel> hotel { get; set; }
        public DbSet<hotel_room> hotel_room { get; set; }
        public DbSet<hotelbooking> hotelbooking { get; set; }
        public DbSet<indirect> indirect { get; set; }
        public DbSet<package> package { get; set; }
        public DbSet<staff> staff { get; set; }
        public DbSet<tag> tag { get; set; }
        public DbSet<vehicle> vehicle { get; set; }
        public DbSet<vehiclebooking> vehiclebooking { get; set; }
    }
}
