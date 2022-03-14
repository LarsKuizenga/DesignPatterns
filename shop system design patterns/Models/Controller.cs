using shop_system_design_patterns.models.Stocker_Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
	class Controller
	{
		public Store Store { get; set; }
		public Random Random { get; set; }

		public Controller()
		{
			Store = null;
		}

		public void Initialize()
		{
			Store = new Store("Raamy's Ratelaars", InitializeWarehouse())
			{
				Shelves = InitializeShelves(),
				People = InitializePeople()
			};
		}

		private Warehouse InitializeWarehouse()
		{
			Warehouse warehouse = new();

			int amountOfProducts = Random.Next(20, 51);
			warehouse.FillStorage(GenerateProductCategory(), amountOfProducts);

			return warehouse;
		}

		private List<Shelve> InitializeShelves()
		{
			List<Shelve> shelves = new();

			int amountOfShelves = Random.Next(30, 41);
			for (int i = 0; i < amountOfShelves; i++)
			{
				ProductCategory shelveProductCategory = GenerateProductCategory();
				Shelve shelve = new(shelveProductCategory, new ShelveManagement());

				int amountOfProducts = Random.Next(10, 21);
				shelve.FillStorage(shelveProductCategory, amountOfProducts);

				shelves.Add(shelve);
			}

			return shelves;
		}

		private List<Person> InitializePeople()
		{
			List<Person> people = new();

			int amountOfPeople = Random.Next(40, 51);
			for (int i = 0; i < amountOfPeople; i++)
			{
				Person person;
				if(Random.Next(4) == 0)
				{
					person = new Customer(GenerateRandomName());
				}
				else
				{
					person = StockerCreator.CreateStocker(GenerateProductCategory(), GenerateRandomName());
				}
				people.Add(person);
			}

			return people;
		}

		private ProductCategory GenerateProductCategory()
		{
			int categoryNumber = Random.Next(4);

			return categoryNumber switch
			{
				1 => ProductCategory.Chair,
				2 => ProductCategory.Couch,
				3 => ProductCategory.Table,
				_ => ProductCategory.Bed,
			};
		}

		private string GenerateRandomName()
		{
			List<string> nameList = new List<string>()
			{
				"Raamy",
				"Lars",
				"Milou",
				"Maartje"
			};

			int nameIndex = Random.Next(0, nameList.Count);

			return nameList[nameIndex];
		}
	}
}
