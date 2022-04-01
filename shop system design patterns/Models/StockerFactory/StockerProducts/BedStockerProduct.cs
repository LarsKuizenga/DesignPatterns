using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    class BedStockerProduct : StockerProduct
    {
        /// <summary>
        /// Stocker responsible for restocking shelves of bed ProductCategory.
        /// </summary>
        public BedStockerProduct(string name) : base(name)
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
                Task.StartTimeFragment(8, TaskCategory.Stocking, shelve);
            }

            if (!warehouse.HasProductAmount(ProductCategory.Bed))
            {
                return $"No products of {ProductCategory.Bed} left in warehouse";
            }

            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Bed));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {Task.TimeLeft} minutes";
        }
    }
}
