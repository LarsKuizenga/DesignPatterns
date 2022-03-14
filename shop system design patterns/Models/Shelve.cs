using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Shelve : Storage
    {
        public ProductCategory Category { get; set; }
        public ShelveManagement ShelveManagement { get; set; }
        
        public Shelve(ProductCategory category, ShelveManagement shelveManagement)
        {
            Category = category;
            ShelveManagement = shelveManagement;
        }

        //Methods not added yet
    }
}
