using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class BedStockerProduct : StockerProduct
    {
        public BedStockerProduct(string name) : base(name)
        {

        }

        public override string Stocking(Shelve shelve)
        {
            if (TimeFragment.TaskName == TaskCategory.Purchasing)
			{
                return $"{Name} can't be stocking right now, they're doing something else";
			}
            if (TimeFragment.TimeLeft == null)
			{
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(5, TaskCategory.Stocking);
			}
            shelve.AddProduct(Store.Warehouse.TakeProduct(ProductCategory.Bed));

            return $"{Name} is stocking the beds for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
