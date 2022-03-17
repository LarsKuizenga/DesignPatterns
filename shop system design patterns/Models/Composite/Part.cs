using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
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
