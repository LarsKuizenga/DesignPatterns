using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models.Stocker_Creator
{
    class CouchStockerCreator : StockerCreator
    {
        public CouchStockerCreator()
        {
        }

        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Couchstocker: " + name;
            return new CouchStockerProduct(returnName);
        }
    }
}
