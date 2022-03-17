using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models.Stocker_Creator
{
    class BedStockerCreator : StockerCreator
    {
        public BedStockerCreator()
        {
        }

        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Bedstocker: " + name;
            return new BedStockerProduct(returnName);
        }
    }
}
