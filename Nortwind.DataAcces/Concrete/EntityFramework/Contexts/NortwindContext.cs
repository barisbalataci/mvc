using Nortwind.DataAcces.Concrete.Mappings;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nortwind.DataAcces.Concrete.EntityFramework.Contexts
{
    public class NortwindContext : DbContext
    {
        public NortwindContext() : base("Name=NorthwindConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
