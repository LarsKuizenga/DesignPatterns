
namespace FrenchutoShop.Models.Composite
{
    /// <summary>
    /// Composite class which represents a component with a name which can't hold copies of IComponents.
    /// </summary>
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
