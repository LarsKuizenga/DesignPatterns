
namespace FrenchutoShop.Models.Stocker_Creator
{
    /// <summary>
    /// Creator responsible for creating TableStockers.
    /// </summary>
    class TableStockerCreator : StockerCreator
    {
        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Tablestocker: " + name;
            return new TableStockerProduct(returnName);
        }
    }
}
