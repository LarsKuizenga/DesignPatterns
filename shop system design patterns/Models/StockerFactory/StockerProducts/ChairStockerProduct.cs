using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    class ChairStockerProduct : StockerProduct
    {
        /// <summary>
        /// Stocker responsible for restocking shelves of chair ProductCategory.
        /// </summary>
        public ChairStockerProduct(string name) : base(name)
        {

        }

        public override string Stocking(Shelve shelve, Warehouse warehouse)
        {
            if (Task.TaskName == TaskCategory.Purchasing)
            {
                return $"{Name} can't be stocking right now, they're doing something else";
            }

            if (Task.TimeLeft == 0)
            {
                Task.StartTimeFragment(6, TaskCategory.Stocking, shelve);
            }

            if (!warehouse.HasProductAmount(ProductCategory.Chair))
            {
                return $"No products of {ProductCategory.Chair} left in warehouse";
            }

            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Chair));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {Task.TimeLeft} minutes";
        }
    }
}
