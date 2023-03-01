using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ElectronicShopCodeFirstFromDB
{
    public partial class ElectronicShopEntities : DbContext
    {
        public ElectronicShopEntities()
            : base("name=ElectronicShopConnection")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Current)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Voltage)
                .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Inventory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);
        }
    }
}
