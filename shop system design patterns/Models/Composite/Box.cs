using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    class Box : IComponent
    {
        public List<IComponent> Children { get; set; } = new List<IComponent>();

        public void Add(IComponent component) 
        {
            Children.Add(component);
        }

        public void Remove(IComponent component)
        {
            Children.Remove(component);
        }

        public string PrintName()
        {
            string composedString = "Box(";
            foreach(IComponent Child in Children)
			{
                composedString += PrintName();
			}
            return composedString + ")";
        }
    }
}
