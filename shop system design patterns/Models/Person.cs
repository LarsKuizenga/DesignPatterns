using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Base class keeping track of current task.
    /// </summary>
    abstract class Person
    {
        public string Name { get; set; }
        public Task Task { get; set; }

        public Person(string name)
        {
            Name = name;
            Task = new Task();
        }

        public abstract string Purchase(Shelve shelve);

        public string GetTimeFragmentShelveId()
        {
            return Task.Shelve == null ? "None" : Task.Shelve.Id.ToString();
        }

        public void Update()
        {
            Task.Tick();
        }
    }
}
