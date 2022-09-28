using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesProject.Models.ViewModels;

namespace SalesProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<ProductA> ProductAs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }


        public DbSet<SalesProject.Models.ViewModels.ProductCreateViewModel> ProductCreateViewModel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.MenuIid).HasColumnName("MenuIID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });
        }
    }
}
