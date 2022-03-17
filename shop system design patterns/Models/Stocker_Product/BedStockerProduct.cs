using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    class BedStockerProduct : StockerProduct
    {
        public BedStockerProduct(string name) : base(name)
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
                TimeFragment.StartTimeFragment(5, TaskCategory.Stocking, shelve);
			}
            if (!warehouse.HasProductAmount(ProductCategory.Bed))
            {
                return $"No products of {ProductCategory.Bed} left in warehouse";
            }
            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Bed));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
