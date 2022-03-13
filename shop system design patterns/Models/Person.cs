using shop_system_design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
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

        public abstract string Purchase(ProductCategory productCategory);

        public void Update()
        {
            TimeFragment.Update();
        }
    }
}
