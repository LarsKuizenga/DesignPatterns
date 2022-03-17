using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models.Stocker_Creator
{
    class ChairStockerCreator : StockerCreator
    {
        public ChairStockerCreator()
        {
        }

        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Chairstocker: " + name;
            return new ChairStockerProduct(returnName);
        }
    }
}
