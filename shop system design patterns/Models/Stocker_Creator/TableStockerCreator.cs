using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models.Stocker_Creator
{
    class TableStockerCreator : StockerCreator
    {
        public TableStockerCreator()
        {
        }

        public override StockerProduct CreateProduct(string name)
        {
            string returnName = "Tablestocker: " + name;
            return new TableStockerProduct(returnName);
        }
    }
}
