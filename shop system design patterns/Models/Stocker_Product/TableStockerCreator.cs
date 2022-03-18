using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    class TableStockerProduct : StockerProduct
    {
        public TableStockerProduct(string name) : base(name)
        {

        }

        public override string Stocking(Shelve shelve, Warehouse warehouse)
        {
            if (TimeFragment.TaskName == TaskCategory.Purchasing)
            {
                return $"{Name} can't be stocking right now, they're doing something else";
            }
            if (TimeFragment.TimeLeft == 0)
            {
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(4, TaskCategory.Stocking, shelve);
            }
            if (!warehouse.HasProductAmount(ProductCategory.Table))
            {
                return $"No products of {ProductCategory.Table} left in warehouse";
            }
            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Table));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
