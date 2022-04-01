
namespace FrenchutoShop.Models.Stocker_Creator
{
    /// <summary>
    /// Creator responsible for creating CouchStockers.
    /// </summary>
    class CouchStockerCreator : StockerCreator
    {
        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Couchstocker: " + name;
            return new CouchStockerProduct(returnName);
        }
    }
}
