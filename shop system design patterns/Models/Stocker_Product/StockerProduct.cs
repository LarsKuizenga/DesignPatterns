using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    abstract class StockerProduct : Person
    {		
		public StockerProduct(string name) : base(name)
		{
		}

		//TODO: Stocker can stock on multiple shelves, unwanted behaviour
		public abstract string Stocking(Shelve shelve, Warehouse warehouse);

        public override string Purchase(Shelve shelve)
		{
			if(TimeFragment.TaskName == TaskCategory.Stocking)
			{
				return $"{Name} is a {GetType().Name[0..^7]} and is doing their job right now, no shopping!";
			}
			if (TimeFragment.TimeLeft == null)
			{
				//TODO: Determine timefragments per task
				TimeFragment.StartTimeFragment(1, TaskCategory.Purchasing, shelve);
			}
			if(!shelve.HasProductAmount())
			{
				return $"No products left in this {shelve.Category} shelve";
			}
			shelve.RemoveProduct();

			return $"{Name} is buying some {shelve.Category}s (with a discount!) in shelve:{shelve.Id} for another {TimeFragment.TimeLeft} minutes";
		}

		public static Type GetStockerProductCategory(ProductCategory productCategory)
		{
            return productCategory switch
            {
                ProductCategory.Bed => typeof(BedStockerProduct),
                ProductCategory.Chair => typeof(ChairStockerProduct),
                ProductCategory.Couch => typeof(CouchStockerProduct),
                _ => typeof(TableStockerProduct),
            };
        }
	}
}
