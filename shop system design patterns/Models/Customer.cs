using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
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
                TimeFragment.StartTimeFragment(1, TaskCategory.Purchasing, shelve);
            }
            if (!shelve.HasProductAmount())
            {
                return $"No products left in this {shelve.Category} shelve";
            }
            shelve.RemoveProduct();

            return $"{Name} is buying some {shelve.Category}s in shelve:{shelve.Id} for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
