using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Warehouse
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(ProductCategory productCategory)
        {
            Product product = Products.First(p => p.Category == productCategory);
            if(product != null)
			{
                Products.Remove(product);
            }
            else
			{
                //TODO: Show unavailable items in log?
                Console.WriteLine($"No products of {productCategory} left");
			}
        }
    }
}
