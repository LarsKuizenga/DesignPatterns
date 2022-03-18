using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    abstract class Person
    {
        public string Name { get; set; }
        public TimeFragment TimeFragment { get; set; }

        public Person(string name) 
        {
            Name = name;
            TimeFragment = new TimeFragment();
        }

        public abstract string Purchase(Shelve shelve);

        public string GetTimeFragmentShelveId()
        {
            return TimeFragment.Shelve == null ? "None" : TimeFragment.Shelve.Id.ToString();
        }

        public void Update()
        {
            TimeFragment.Tick();
        }
    }
}
