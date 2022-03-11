using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Shelve
    {
        public ProductCategory Category { get; set; }
        public ShelveManagement ShelveManagement { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        
        public Shelve(ProductCategory category, ShelveManagement shelveManagement)
        {
            Category = category;
            ShelveManagement = shelveManagement;
        }

        public void AddProduct(Product product) 
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        //Methods not added yet
    }
}
