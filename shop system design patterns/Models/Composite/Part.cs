using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Part : IComponent
    {
        public string Name { get; set; }

        public Part(string name)
		{
            Name = name;
		}

        public string PrintName()
        {
            return Name;
        }
    }
}
