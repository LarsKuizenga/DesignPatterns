using System.Collections.Generic;

namespace FrenchutoShop.Models.Composite
{
    /// <summary>
    /// Composite class which can hold a set of IComponents which it also dirives from.
    /// </summary>
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

            foreach (IComponent Child in Children)
            {
                composedString += PrintName();
            }

            return composedString + ")";
        }
    }
}
