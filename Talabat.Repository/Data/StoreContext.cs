using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Repository.Configurations;

namespace Talabat.Repository.Data
{
	public class StoreContext : DbContext
	{
		public StoreContext(DbContextOptions<StoreContext> options) : base(options) 
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//base.OnModelCreating(modelBuilder); i don't need to use constructor of parent because he don't have dbset or Fluent API there

			//modelBuilder.ApplyConfiguration(new ProductConfigurations());
			//modelBuilder.ApplyConfiguration(new ProductBrandConfigurations());
			//modelBuilder.ApplyConfiguration(new ProductCategoryConfigurations());
			//instead of use this three lines above i can use this one down and it's ApplyConfiguration for any class implement IEntityTypeConfiguration
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("");
    }
}
