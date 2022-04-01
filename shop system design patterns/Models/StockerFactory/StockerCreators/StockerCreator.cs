using FrenchutoShop.Models.Enums;
using System;

namespace FrenchutoShop.Models.Stocker_Creator
{
    /// <summary>
    /// Factory which requires all derivatives to implement the factory method.
    /// </summary>
    abstract class StockerCreator
    {
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
