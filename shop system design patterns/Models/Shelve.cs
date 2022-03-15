using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
	class Shelve : Storage
	{
		public ProductCategory Category { get; set; }
		public ShelveManagement ShelveManagement { get; set; }
		public static int MinAmountOfProducts { get; set; } = 5;
        
        public Shelve(ProductCategory category, ShelveManagement shelveManagement)
        {
            Category = category;
            ShelveManagement = shelveManagement;
        }

		public void RemoveProduct()
		{
			Product product = Products.First();
			if (product != null)
			{
				Products.Remove(product);
			}
			else
			{
				//TODO: Show unavailable items in log?
				Console.WriteLine($"No products left");
			}
		}

		public List<String> Update(List<Person> people)
		{
			List<String> stringList = new();

			if(Products.Count < MinAmountOfProducts)
			{
				ShelveManagement.Subscribe(GetRandomStockerOfShelveCategory(people));
				stringList.AddRange(ShelveManagement.Notify(this));
			}
			if(ShelveManagement.Stockers.Count == 0)
			{
				return new List<String>();
			}
			if(ShelveManagement.Stockers[0].TimeFragment.TaskName == TaskCategory.Stocking)
			{
				foreach (StockerProduct stocker in ShelveManagement.Stockers)
				{
					stringList.Add(stocker.Stocking(this));
				}
			}

			return stringList;
		}

		private StockerProduct GetRandomStockerOfShelveCategory(List<Person> people)
		{
			return (StockerProduct) people.First(p => p.GetType() == StockerProduct.GetStockerProductCategory(Category));
		}
	}
}
