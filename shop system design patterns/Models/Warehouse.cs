using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Warehouse : Storage
    {
		public Product TakeProduct(ProductCategory productCategory)
		{
			Product product = Products.First(p => p.Category == productCategory);
			if (product != null)
			{
				Products.Remove(product);
				return product;
			}
			else
			{
				//TODO: Show unavailable items in log?
				Console.WriteLine($"No products of {productCategory} left");
				return null;
			}
		}
	}
}
