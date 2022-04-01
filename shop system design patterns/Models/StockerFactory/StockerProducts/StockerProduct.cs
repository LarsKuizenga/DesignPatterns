using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;
using System;

namespace FrenchutoShop.Models
{
    abstract class StockerProduct : Person
    {
        /// <summary>
        /// Represents a person who can restock shelves as well as purchase from them.
        /// </summary>
        public StockerProduct(string name) : base(name)
        {
        }

        public abstract string Stocking(Shelve shelve, Warehouse warehouse);

        public override string Purchase(Shelve shelve)
        {
            if (Task.TaskName == TaskCategory.Stocking)
            {
                return $"{Name} is a {GetType().Name[0..^7]} and is doing their job right now, no shopping!";
            }

            if (Task.TimeLeft == 0)
            {
                Task.StartTimeFragment(3, TaskCategory.Purchasing, shelve);
            }

            if (!shelve.HasProductAmount())
            {
                return $"No products left in this {shelve.Category} shelve";
            }

            shelve.RemoveProduct();

            return $"{Name} is buying some {shelve.Category}s (with a discount!) in shelve:{shelve.Id} for another {Task.TimeLeft} minutes";
        }

        public static Type GetStockerProductCategory(ProductCategory productCategory)
        {
            return productCategory switch
            {
                ProductCategory.Bed => typeof(BedStockerProduct),
                ProductCategory.Chair => typeof(ChairStockerProduct),
                ProductCategory.Couch => typeof(CouchStockerProduct),
                ProductCategory.Table => typeof(TableStockerProduct),
                _ => typeof(BedStockerProduct),
            };
        }
    }
}
