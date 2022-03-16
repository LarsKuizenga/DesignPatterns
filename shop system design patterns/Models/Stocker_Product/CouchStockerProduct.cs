using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class CouchStockerProduct : StockerProduct
    {
        public CouchStockerProduct(string name) : base(name)
		{

		}

        public override string Stocking(Shelve shelve, Warehouse warehouse)
        {
            if (TimeFragment.TaskName == TaskCategory.Purchasing)
            {
                return $"{Name} can't be stocking right now, they're doing something else";
            }
            if (TimeFragment.TimeLeft == null)
            {
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(4, TaskCategory.Stocking);
            }
            if (!warehouse.HasProductAmount(ProductCategory.Couch))
            {
                return $"No products of {ProductCategory.Couch} left in warehouse";
            }
            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Couch));
              
            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
