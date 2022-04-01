using FrenchutoShop.Models.Observer;
using System.Collections.Generic;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Holds the warehouse, all shelves and people within the store
    /// </summary>
    class Store
    {
        public string Name { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Shelve> Shelves { get; set; } = new List<Shelve>();
        public List<Person> People { get; set; } = new List<Person>();

        public Store(string name, Warehouse warehouse)
        {
            Name = name;
            Warehouse = warehouse;
        }
    }
}
