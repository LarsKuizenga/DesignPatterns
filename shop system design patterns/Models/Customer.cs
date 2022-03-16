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

        public override string Purchase(Shelve shelve)
        {
            if (TimeFragment.TimeLeft == null)
            {
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(1, TaskCategory.Purchasing);
            }
            if (!shelve.HasProductAmount())
            {
                return $"No products left in this {shelve.Category} shelve";
            }
            shelve.RemoveProduct();

            return $"{Name} is buying some {shelve.Category}s for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
