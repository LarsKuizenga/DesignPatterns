using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    abstract class StockerProduct : Person
    {		
		public StockerProduct(string name) : base(name)
		{
		}

		public abstract string Stocking(Shelve shelve);

        public override string Purchase(Shelve shelve)
		{
			if(TimeFragment.TaskName == TaskCategory.Stocking)
			{
				return $"{Name} is a {GetType().Name[0..^7]} and is doing their job right now, no shopping!";
			}
			if (TimeFragment.TimeLeft == null)
			{
				//TODO: Determine timefragments per task
				TimeFragment.StartTimeFragment(1, TaskCategory.Stocking);
			}
			shelve.RemoveProduct();

			return $"{Name} is buying some {shelve.Category}'s (with a discount!) for another {TimeFragment.TimeLeft} minutes";
		}

		public static Type GetStockerProductCategory(ProductCategory productCategory)
		{
			switch (productCategory)
			{
				case ProductCategory.Bed:
					return typeof(BedStockerProduct);
				case ProductCategory.Chair:
					return typeof(ChairStockerProduct);
				case ProductCategory.Couch:
					return typeof(CouchStockerProduct);
				case ProductCategory.Table:
					return typeof(TableStockerProduct);
				default:
					return typeof(TableStockerProduct);
			}
		}
	}
}
