﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebOrders.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class saleManagementEntities : DbContext
    {
        public saleManagementEntities()
            : base("name=saleManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accountant> accountants { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<deliveryBill> deliveryBills { get; set; }
        public virtual DbSet<detailOrder> detailOrders { get; set; }
        public virtual DbSet<detailReceipt> detailReceipts { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<receipt> receipts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
