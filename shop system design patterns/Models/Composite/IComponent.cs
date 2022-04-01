
namespace FrenchutoShop.Models.Composite
{
    /// <summary>
    /// Interface to require all components to be able to recursively print their name.
    /// </summary>
    interface IComponent
    {
        string PrintName();
    }
}
