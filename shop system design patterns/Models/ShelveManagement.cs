using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenchutoShop.Models.Stocker_Creator;

namespace FrenchutoShop.Models
{
    class ShelveManagement
    {
        public List<StockerProduct> Stockers { get; set; } = new List<StockerProduct>();

        public void Subscribe(StockerProduct stocker) 
        {
            Stockers.Add(stocker);
        }

        public void UnSubscribe(StockerProduct stocker)
        {
            Stockers.Remove(stocker);
        }

        //TODO: Check data type
        public List<String> Notify(Shelve shelve, Warehouse warehouse)
        {
            List<String> stringList = new();

            foreach (StockerProduct stocker in Stockers)
            {
                if (stocker.TimeFragment.TaskName == TaskCategory.None)
                {
                    stringList.Add(stocker.Stocking(shelve, warehouse));
                }
            }

            return stringList;
        }
    }
}
