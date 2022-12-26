using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class DataContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Mother> mother { get; set; }
        public DbSet<Father> father { get; set; }
        public DbSet<ReligiousInfo> church { get; set; }
        public DbSet<Grades> grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=c8xz1duey1.database.windows.net; Database=md-warehouse-project; User ID=mduser; Password=Kn#NeGh0l6zj^!u*CH; MultipleActiveResultSets=true");
            }
        }

    }
}
