using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    class CouchStockerProduct : StockerProduct
    {
        /// <summary>
        /// Stocker responsible for restocking shelves of couch ProductCategory.
        /// </summary>
        public CouchStockerProduct(string name) : base(name)
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
                Task.StartTimeFragment(5, TaskCategory.Stocking, shelve);
            }

            if (!warehouse.HasProductAmount(ProductCategory.Couch))
            {
                return $"No products of {ProductCategory.Couch} left in warehouse";
            }

            shelve.AddProduct(warehouse.TakeProduct(ProductCategory.Couch));

            return $"{Name} is stocking the {shelve.Category}s in shelve:{shelve.Id} for another {Task.TimeLeft} minutes";
        }
    }
}
