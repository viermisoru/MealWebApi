﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MealDBNewEntities : DbContext
    {
        public MealDBNewEntities()
            : base("name=MealDBNewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblMenu> tblMenus { get; set; }
        public virtual DbSet<tblMenuItem> tblMenuItems { get; set; }
        public virtual DbSet<tblMenuItemType> tblMenuItemTypes { get; set; }
        public virtual DbSet<tblProviderMenuItem> tblProviderMenuItem { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserMenu> tblUserMenus { get; set; }
        public virtual DbSet<tblToken> tblTokens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
