﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Casgem_Portfolio.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CasgemPortfolioEntities : DbContext
    {
        public CasgemPortfolioEntities()
            : base("name=CasgemPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblFeature> TblFeature { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblMessage> TblMessage { get; set; }
        public virtual DbSet<TblTry> TblTry { get; set; }
        public virtual DbSet<TblResume> TblResume { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblEmployee> TblEmployee { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblReference> TblReference { get; set; }
    }
}
