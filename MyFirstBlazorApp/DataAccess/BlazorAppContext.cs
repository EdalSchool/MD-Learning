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
        public DbSet<InOuts> InOuts { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Storage> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=MyFirstBlazorAppDb; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
        }
    }
}
