using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models.Stocker_Creator
{
    abstract class StockerCreator : Person
    {
        public bool IsStocking { get; set; }

        protected StockerCreator(string name) : base(name)
        {
        }

        public abstract IStockerProduct CreateProduct();

        public abstract void Stock();
        
        public override void Purchase()
        {
            throw new NotImplementedException();
        }
    }
}
