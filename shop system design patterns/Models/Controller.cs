using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;
using FrenchutoShop.Models.Stocker_Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Holds, initializes and updates all Store objects, updates tab views.
    /// </summary>
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
            Store = new Store("Raamy's Ratelaars", InitializeWarehouse());
            Store.People = InitializePeople();
            Store.Shelves = InitializeShelves();
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

        private List<Shelve> InitializeShelves()
        {
            List<Shelve> shelves = new();

            int amountOfShelves = Random.Next(30, 41);

            for (int i = 0; i < amountOfShelves; i++)
            {
                ProductCategory shelveProductCategory = GenerateProductCategory();
                Shelve shelve = new(i.ToString(), shelveProductCategory, new ShelveManagement());

                int amountOfProducts = Random.Next(10, 21);
                shelve.FillStorage(shelveProductCategory, amountOfProducts);

                for (int j = 0; j < 5; j++)
                {
                    StockerProduct stocker = shelve.GetRandomStockerOfShelveCategory(Store.People);

                    while (shelve.ShelveManagement.Stockers.Contains(stocker))
                    {
                        stocker = shelve.GetRandomStockerOfShelveCategory(Store.People);
                    }

                    shelve.ShelveManagement.Subscribe(stocker);
                }

                shelves.Add(shelve);
            }

            return shelves;
        }
        #endregion

        #region Update
        public List<string> Update()
        {
            List<string> stringList = new();

            int randomAmountOfPurchases = Random.Next(1, 5);

            for (int i = 0; i < randomAmountOfPurchases; i++)
            {
                stringList.AddRange(PersonPurchases());
            }

            stringList.AddRange(CustomersLeave());

            foreach (Shelve shelve in Store.Shelves)
            {
                stringList.AddRange(shelve.Update(Store.Warehouse));
            }

            stringList.AddRange(Store.Warehouse.Update());

            foreach (Person person in Store.People)
            {
                person.Update();
            }

            return stringList;
        }

        private List<string> PersonPurchases()
        {
            List<string> stringList = new();

            Person person;
            bool isNewCustomer = Convert.ToBoolean(Random.Next(0, 2));

            if (isNewCustomer)
            {
                Store.People.Add(new Customer(GenerateRandomName()));
                person = Store.People.Last();
                stringList.Add($"{person.Name} enters the store");
            }
            else
            {
                int randomCustomer = Random.Next(0, Store.People.Count);
                person = Store.People[randomCustomer];
            }

            int randomShelve = Random.Next(0, Store.Shelves.Count);
            stringList.Add(person.Purchase(Store.Shelves[randomShelve]));

            return stringList;
        }

        private List<string> CustomersLeave()
        {
            List<string> stringList = new();

            int amountLeaves = Random.Next(1, 3);

            for (int i = 0; i < amountLeaves; i++)
            {
                int randomPerson = Random.Next(0, Store.People.Count);
                Person person = Store.People[randomPerson];

                if (person is Customer)
                {
                    stringList.Add($"{person.Name} leaves the store");
                    Store.People.Remove(person);
                }
            }

            return stringList;
        }

        public void AllCustomersLeave()
        {
            Store.People.RemoveAll(p => p.GetType() == typeof(Customer));
        }

        #endregion

        #region TabViewUpdater
        public ListViewItem[] UpdateShelveListView()
        {
            List<ListViewItem> listViewItemList = new();

            foreach (Shelve shelve in Store.Shelves)
            {
                string[] properties = { shelve.Id.ToString(), shelve.Category.ToString(), shelve.Products.Count.ToString() };
                listViewItemList.Add(new ListViewItem(properties));
            }

            return listViewItemList.ToArray();
        }

        public ListViewItem[] UpdateStockersListView()
        {
            List<ListViewItem> listViewItemList = new();

            foreach (StockerProduct stocker in Store.People.FindAll(p => p.GetType() != typeof(Customer)))
            {
                string[] properties = { stocker.Name, stocker.Task.TaskName.ToString(), stocker.Task.TimeLeft.ToString(), stocker.GetTimeFragmentShelveId() };
                listViewItemList.Add(new ListViewItem(properties));
            }

            return listViewItemList.ToArray();
        }

        public ListViewItem[] UpdateCustomersListView()
        {
            List<ListViewItem> listViewItemList = new();

            foreach (Customer customer in Store.People.FindAll(p => p.GetType() == typeof(Customer)))
            {
                string[] properties = { customer.Name, customer.Task.TaskName.ToString(), customer.Task.TimeLeft.ToString(), customer.GetTimeFragmentShelveId() };
                listViewItemList.Add(new ListViewItem(properties));
            }

            return listViewItemList.ToArray();
        }

        public ListViewItem[] UpdateWarehouseListView()
        {
            List<ListViewItem> listViewItemList = new();

            foreach (ProductCategory productCategory in (ProductCategory[])Enum.GetValues(typeof(ProductCategory)))
            {
                int categoryProductCount = Store.Warehouse.Products.FindAll(p => p.Category == productCategory).Count;
                string[] properties = { productCategory.ToString(), categoryProductCount.ToString() };
                listViewItemList.Add(new ListViewItem(properties));
            }

            return listViewItemList.ToArray();
        }
        #endregion

        private ProductCategory GenerateProductCategory()
        {
            int categoryNumber = Random.Next(Enum.GetNames(typeof(ProductCategory)).Length);

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
            int nameIndex = Random.Next(0, NameCollection.List.Count);

            return NameCollection.List[nameIndex];
        }
    }
}
