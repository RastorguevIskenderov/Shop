﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesShop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SneakerShopIREntities : DbContext
    {
        private static SneakerShopIREntities _context;
        public SneakerShopIREntities()
            : base("name=SneakerShopIREntities")
        {
        }

        public static SneakerShopIREntities GetContext()
        {
            if(_context == null)
            {
                _context = new SneakerShopIREntities();
            }
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assortment> Assortment { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ShoesType> ShoesType { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Stuff> Stuff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
