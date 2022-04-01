
namespace FrenchutoShop.Models.Stocker_Creator
{
    /// <summary>
    /// Creator responsible for creating ChairStockers.
    /// </summary>
    class ChairStockerCreator : StockerCreator
    {
        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Chairstocker: " + name;
            return new ChairStockerProduct(returnName);
        }
    }
}
