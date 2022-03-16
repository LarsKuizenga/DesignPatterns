using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
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

		public List<String> Update(Warehouse warehouse)
		{
			List<String> stringList = new();
			
			if(ShelveManagement.Stockers.Count == 0)
			{
				return new List<String>();
			}
			if (!HasProductAmount(MinAmountOfProducts))
			{
				stringList.AddRange(ShelveManagement.Notify(this, warehouse));
			}
			else
			{
				foreach (StockerProduct stocker in ShelveManagement.Stockers)
				{
					if (stocker.TimeFragment.TaskName == TaskCategory.Stocking)
					{
						stringList.Add(stocker.Stocking(this, warehouse));
					}
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
