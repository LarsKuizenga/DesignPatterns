using FrenchutoShop.Models.Enums;
using FrenchutoShop.Models.Observer;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Represents a task of TaskCategory to be completed by a person.
    /// </summary>
    class Task
    {
        public uint TimeLeft { get; set; }
        public TaskCategory TaskName { get; set; }
        public Shelve Shelve { get; set; }

        public void StartTimeFragment(uint duration, TaskCategory taskCategory, Shelve shelve)
        {
            TimeLeft = duration;
            TaskName = taskCategory;
            Shelve = shelve;
        }

        public void Tick()
        {
            if (TimeLeft > 0)
                TimeLeft--;

            if (TimeLeft == 0)
            {
                TaskName = TaskCategory.None;
                Shelve = null;
            }
        }
    }
}
