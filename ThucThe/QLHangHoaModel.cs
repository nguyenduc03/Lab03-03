using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab03_03.ThucThe
{
    public partial class QLHangHoaModel : DbContext
    {
        public QLHangHoaModel()
            : base("name=QLHangHoaModel")
        {
        }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
