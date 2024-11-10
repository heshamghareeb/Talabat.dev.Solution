using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string PictureUrl { get; set; }
		public decimal Price { get; set; }
		//[ForeignKey(nameof(Product.Brand))] // if i don't want write data annotion then i shoud write it flunt api
		public int BrandId { get; set; } // Foregin Key Column : ProductBrand [Brand] // Second way if i want to change name

		//public int ProductBrandId { get; set; } // Foregin Key Column : ProductBrand [Brand]  // First Way

		//[InverseProperty(nameof(ProductBrand.Products))] do this if there more then one relation in Brand
		public ProductBrand Brand { get; set; } // Navigational Property [ONE]

		[ForeignKey(nameof(Product.Category))] // if i don't want write data annotion then i shoud write it flunt api
		public int CategoryId { get; set; } // Foregin Key Column : ProductCategory [Category]
		//public int ProductCategoryId { get; set; } // Foregin Key Column : ProductCategory [Category]
		public ProductCategory Category { get; set; } // Navigational Property [ONE]
	}
}
