using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models.Stocker_Creator
{
    abstract class StockerCreator
    {
        protected StockerCreator()
        {
        }

        public abstract StockerProduct CreateProduct(string name);

        public static StockerProduct CreateStocker(ProductCategory productCategory, string name)
		{
			return productCategory switch
			{
				ProductCategory.Bed => new BedStockerCreator().CreateProduct(name),
				ProductCategory.Chair => new ChairStockerCreator().CreateProduct(name),
				ProductCategory.Couch => new CouchStockerCreator().CreateProduct(name),
				ProductCategory.Table => new TableStockerCreator().CreateProduct(name),
				_ => throw new Exception($"Given ProductCategory: {productCategory} does not exist"),
			};
		}
    }
}
