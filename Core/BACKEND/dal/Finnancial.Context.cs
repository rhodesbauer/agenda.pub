﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BACKEND.dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinnancialEntities : DbContext
    {
        public FinnancialEntities()
            : base("name=FinnancialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<relAlertUser> relAlertUser { get; set; }
        public virtual DbSet<relEntriesDescription> relEntriesDescription { get; set; }
        public virtual DbSet<relEntriesScope> relEntriesScope { get; set; }
        public virtual DbSet<relScopeGroup> relScopeGroup { get; set; }
        public virtual DbSet<tblAccess> tblAccess { get; set; }
        public virtual DbSet<tblAlert> tblAlert { get; set; }
        public virtual DbSet<tblEntries> tblEntries { get; set; }
        public virtual DbSet<tblEntryDescription> tblEntryDescription { get; set; }
        public virtual DbSet<tblGroup> tblGroup { get; set; }
        public virtual DbSet<tblScope> tblScope { get; set; }
        public virtual DbSet<tblUser> tblUser { get; set; }
    }
}
