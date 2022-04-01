using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Represents a person who can only buy products from the store.
    /// </summary>
    class Customer : Person
    {
        public Customer(string name) : base(name)
        {

        }

        public override string Purchase(Shelve shelve)
        {
            if (Task.TimeLeft == 0)
            {
                Task.StartTimeFragment(3, TaskCategory.Purchasing, shelve);
            }

            if (!shelve.HasProductAmount())
            {
                return $"No products left in this {shelve.Category} shelve";
            }

            shelve.RemoveProduct();

            return $"{Name} is buying some {shelve.Category}s in shelve:{shelve.Id} for another {Task.TimeLeft} minutes";
        }
    }
}
