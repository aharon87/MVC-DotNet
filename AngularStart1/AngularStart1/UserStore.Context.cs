﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularStart1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GiftCardEntities : DbContext
    {
        public GiftCardEntities()
            : base("name=GiftCardEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<GiftCards> GiftCards { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<Receipts> Receipts { get; set; }
        public DbSet<StoreUsers> StoreUsers { get; set; }
    }
}
