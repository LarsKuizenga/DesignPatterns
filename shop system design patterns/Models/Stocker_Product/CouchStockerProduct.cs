using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class CouchStockerProduct : StockerProduct
    {
        public CouchStockerProduct(string name) : base(name)
		{

		}

        public override string Stocking()
        {
            if (TimeFragment.TimeLeft == null)
            {
                //TODO: Determine timefragments per task
                TimeFragment.StartTimeFragment(4);
            }
            return $"Stocking the couch for another {TimeFragment.TimeLeft} minutes";
        }
    }
}
