using shop_system_design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Customer : Person
    {
        public Customer(string name) : base(name)
        {
        }

        public override string Purchase(ProductCategory productCategory)
        {
            if (TimeFragment.TimeLeft == null)
            {
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(1, TaskCategory.Purchasing);
            }
            return $"Buying some {productCategory}'s for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
