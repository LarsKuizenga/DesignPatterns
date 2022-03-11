using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
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

        public void PrintName()
        {
            throw new NotImplementedException();
        }
    }
}
