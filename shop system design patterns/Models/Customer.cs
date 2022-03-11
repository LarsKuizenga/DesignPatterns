using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Customer : Person
    {
        public Customer(string name) : base(name)
        {
        }

        public override void Purchase()
        {
            throw new NotImplementedException();
        }
    }
}
