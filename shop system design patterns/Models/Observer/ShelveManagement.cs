using FrenchutoShop.Models.Enums;
using System.Collections.Generic;

namespace FrenchutoShop.Models.Observer
{
    /// <summary>
    /// Manager which keeps track of which stockers are set to restock shelve products.
    /// </summary>
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

        public List<string> Notify(Shelve shelve, Warehouse warehouse)
        {
            List<string> stringList = new();

            foreach (StockerProduct stocker in Stockers)
            {
                if (stocker.Task.TaskName == TaskCategory.None)
                {
                    stringList.Add(stocker.Stocking(shelve, warehouse));
                }
            }

            return stringList;
        }
    }
}
