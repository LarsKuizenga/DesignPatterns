using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    class ChairStockerProduct : StockerProduct
    {
        public ChairStockerProduct(string name) : base(name)
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
                TimeFragment.StartTimeFragment(3, TaskCategory.Stocking, shelve);
            }
            if (!warehouse.HasProductAmount(ProductCategory.Chair))
            {
                return $"No products of {ProductCategory.Chair} left in warehouse";
            }
            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Chair));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
