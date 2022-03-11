using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Product
    {
        public IComponent Component { get; set; }
        public ProductCategory Category { get; set; } 
        
        public Product(IComponent component, ProductCategory category)
        {
            Component = component;
            Category = category;
        }
    }
}
