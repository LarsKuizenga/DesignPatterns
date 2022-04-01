using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    class TableStockerProduct : StockerProduct
    {
        /// <summary>
        /// Stocker responsible for restocking shelves of table ProductCategory.
        /// </summary>
        public TableStockerProduct(string name) : base(name)
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

            if (!warehouse.HasProductAmount(ProductCategory.Table))
            {
                return $"No products of {ProductCategory.Table} left in warehouse";
            }

            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Table));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {Task.TimeLeft} minutes";
        }
    }
}
