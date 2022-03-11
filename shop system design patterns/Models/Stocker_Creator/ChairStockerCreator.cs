using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models.Stocker_Creator
{
    class ChairStockerCreator : StockerCreator
    {
        public ChairStockerCreator(string name) : base(name)
        {
        }

        public override IStockerProduct CreateProduct()
        {
            throw new NotImplementedException();
        }

        public override void Stock()
        {
            throw new NotImplementedException();
        }
    }
}
