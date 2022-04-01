
namespace FrenchutoShop.Models.Stocker_Creator
{
    /// <summary>
    /// Creator responsible for creating BedStockers.
    /// </summary>
    class BedStockerCreator : StockerCreator
    {
        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Bedstocker: " + name;
            return new BedStockerProduct(returnName);
        }
    }
}
