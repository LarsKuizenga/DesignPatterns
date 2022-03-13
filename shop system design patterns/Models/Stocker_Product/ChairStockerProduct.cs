using shop_system_design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class ChairStockerProduct : StockerProduct
    {
        public ChairStockerProduct(string name) : base(name)
        {

        }

        public override string Stocking()
        {
            if (TimeFragment.TaskName != TaskCategory.Purchasing)
            {
                return $"{Name} can't be stocking right now, they're doing something else";
            }
            if (TimeFragment.TimeLeft == null)
            {
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(3, TaskCategory.Stocking);
            }
            return $"Stocking the chairs for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
