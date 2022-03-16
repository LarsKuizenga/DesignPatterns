using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
	abstract class Storage
	{
		public List<Product> Products { get; set; } = new List<Product>();

		public void FillStorage(ProductCategory productCategory, int amountOfProducts)
		{
			for (int i = 0; i < amountOfProducts; i++)
			{
				AddProduct(new Product(productCategory));
			}
		}

		public void AddProduct(Product product)
		{
			Products.Add(product);
		}

		public bool HasProductAmount(int desired = 0)
		{
			if (Products.Count > desired)
			{
				return true;
			}
			return false;
		}
	}
}
