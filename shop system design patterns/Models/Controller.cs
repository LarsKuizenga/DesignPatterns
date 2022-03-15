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
			Random = new();
			Store = null;
		}

		#region Initialization
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
			for (int i = 0; i < amountOfProducts; i++)
			{
				warehouse.FillStorage(GenerateProductCategory(), 1);
			}

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
				people.Add(StockerCreator.CreateStocker(GenerateProductCategory(), GenerateRandomName()));
			}

			return people;
		}
		#endregion

		#region Update
		public List<String> Update()
		{
			List<String> stringList = new();

			int randomAmountOfPurchases = Random.Next(1, 5);

			for (int i = 0; i < randomAmountOfPurchases; i++)
			{
				stringList.Add(PersonPurchases());
			}
			
			CustomersLeave();

			foreach (Shelve shelve in Store.Shelves)
			{
				stringList.AddRange(shelve.Update(Store.People));
			}
			foreach (Person person in Store.People)
			{
				person.Update();
			}

			return stringList;
		}

		private string PersonPurchases()
		{
			bool isNewCustomer = Convert.ToBoolean(Random.Next(0, 2));

			Person person;
			if (isNewCustomer)
			{
				Store.People.Add(new Customer(GenerateRandomName()));
				person = Store.People.Last();
			}
			else
			{
				int randomCustomer = Random.Next(0, Store.People.Count);
				person = Store.People[randomCustomer];
			}	
			int randomShelve = Random.Next(0, Store.Shelves.Count);
			
			return person.Purchase(Store.Shelves[randomShelve]);
		}

		private void CustomersLeave()
		{
			int amountLeaves = Random.Next(1, 3);
			for (int i = 0; i < amountLeaves; i++)
			{
				int randomPerson = Random.Next(0, Store.People.Count);
				Person person = Store.People[randomPerson];

				if (person is Customer)
				{
					Store.RemovePerson(person);
				}
			}
		}
		#endregion

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
				"Maartje",
				"Brooklyn",
				"Marc",
				"Alondra",
				"Rodrigo",
				"Dania",
				"Aurora",
				"Jermaine",
				"Taniya",
				"Carlos",
				"Avah",
				"Charles",
				"Brice",
				"Jan",
				"Lydia",
				"Jamarcus",
				"Charlie",
				"Melody",
				"Arturo",
				"Jensen",
				"Alden",
				"Skylar",
				"Abram",
				"Boston",
				"Shyla",
				"Jada",
				"Lesly",
				"Vance",
				"Aarav",
				"Martin",
				"Elizabeth",
				"Lilliana",
				"Aryana",
				"Tate",
				"Angelina",
				"Keaton",
				"Jose",
				"Ruth",
				"Uriel",
				"Kyla",
				"Adrianna",
				"Grace",
				"Jason",
				"Judith",
				"Jordyn",
				"India",
				"Dylan",
				"Jasmine",
				"Dillan",
				"Faith",
				"Gretchen",
				"Mathew",
				"Asher",
				"Jordon",
				"Johnathon",
				"Maritza",
				"Keegan",
				"Courtney",
				"Kolten",
				"Armani",
				"Landin",
				"Allie",
				"Gunner",
				"Cameron",
				"Lexie",
				"Jaylon",
				"Maleah",
				"Kayleigh",
				"Derek",
				"Charlee",
				"Shayna",
				"Renee",
				"Christine",
				"Lila",
				"Mikaela",
				"Sierra",
				"Leticia",
				"Silas",
				"Mila",
				"Yael",
				"Mattie",
				"Oswaldo",
				"Kiley",
				"Jordin",
				"Christopher",
				"Valentin",
				"Henry",
				"Gabriella",
				"Tamara",
				"Scarlet",
				"Maddox",
				"Zachery",
				"Jorden",
				"Brian",
				"Jayson",
				"Laura",
				"Skyla",
				"Aydin",
				"Zion",
				"Nylah",
				"Esther",
				"Lilia",
				"Karlee",
				"Gunnar",
				"Mallory",
				"Hanna",
				"Madalynn",
				"Sofia",
				"Toby",
				"Jon",
				"Dalia",
				"Jakayla",
				"Brooke",
				"Rebecca",
				"Anthony",
				"Darius"
			};

			int nameIndex = Random.Next(0, nameList.Count);

			return nameList[nameIndex];
		}
	}
}
