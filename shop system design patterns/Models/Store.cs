using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
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

        public void AddPerson(Person person) 
        {
            People.Add(person);
        }

        public void RemovePerson(Person person)
        {
            People.Remove(person);
        }

        public void AddShelve(Shelve shelve)
        {
            Shelves.Add(shelve);
        }

        public void RemoveShelve(Shelve shelve)
        {
            Shelves.Remove(shelve);
        }
    }
}
