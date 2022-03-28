using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BlazorAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<InOut> InOuts { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Storage> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=MyFirstBlazorAppDb; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData
            (
                new Category { CategoryId = "HCN", CategoryName = "Home Cleaning" },
                new Category { CategoryId = "PNC", CategoryName = "Personal Care" },
                new Category { CategoryId = "VDG", CategoryName = "Video Games" },
                new Category { CategoryId = "KTN", CategoryName = "Kitchen" },
                new Category { CategoryId = "CTH", CategoryName = "Clothes" },
                new Category { CategoryId = "HTH", CategoryName = "Health" },
                new Category { CategoryId = "TYS", CategoryName = "Toys" }
            );

            modelBuilder.Entity<Warehouse>().HasData
            (
                new Warehouse { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "New York Warehouse", WarehouseAddress = "New York City, New York" },
                new Warehouse { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Kansas Warehouse", WarehouseAddress = "Missouri, Kansas" },
                new Warehouse { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Idaho Warehouse", WarehouseAddress = "Idaho Falls, Idaho " }
            );
        }
    }
}
