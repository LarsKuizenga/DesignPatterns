using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class TableStockerProduct : StockerProduct
    {
        public TableStockerProduct(string name) : base(name)
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
                TimeFragment.StartTimeFragment(4, TaskCategory.Stocking);
            }
            shelve.AddProduct(Store.Warehouse.TakeProduct(ProductCategory.Table));

            return $"{Name} is stocking the Table for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
