using FrenchutoShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrenchutoShop.Models.Observer
{
    /// <summary>
    /// Storage class of a specific ProductCategory which allows persons to purchase products from.
    /// </summary>
    class Shelve : Storage
    {
        public string Id { get; set; }
        public ProductCategory Category { get; set; }
        public ShelveManagement ShelveManagement { get; set; }
        public static int MinAmountOfProducts { get; set; } = 5;

        public Shelve(string id, ProductCategory category, ShelveManagement shelveManagement)
        {
            Id = id;
            Category = category;
            ShelveManagement = shelveManagement;
        }

        public void RemoveProduct()
        {
            if (HasProductAmount())
            {
                Product product = Products.First();
                Products.Remove(product);
            }
        }

        public List<string> Update(Warehouse warehouse)
        {
            List<string> stringList = new();

            if (ShelveManagement.Stockers.Count == 0)
            {
                return stringList;
            }

            if (!HasProductAmount(MinAmountOfProducts))
            {
                stringList.AddRange(ShelveManagement.Notify(this, warehouse));
                return stringList;
            }

            foreach (StockerProduct stocker in ShelveManagement.Stockers)
            {
                if (stocker.Task.TaskName == TaskCategory.Stocking && stocker.Task.Shelve.Id == Id)
                {
                    stringList.Add(stocker.Stocking(this, warehouse));
                }
            }

            return stringList;
        }

        public StockerProduct GetRandomStockerOfShelveCategory(List<Person> people)
        {
            List<StockerProduct> stockerProducts = new();

            stockerProducts = people.FindAll(p => p.GetType() == StockerProduct.GetStockerProductCategory(Category)).Cast<StockerProduct>().ToList();
            Random random = new();
            int randomStockerProduct = random.Next(0, stockerProducts.Count);

            return stockerProducts[randomStockerProduct];
        }
    }
}
