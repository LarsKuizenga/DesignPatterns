using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
	class TimeFragment
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
			if(TimeLeft > 0)
				TimeLeft--;

			if (TimeLeft == 0)
			{
				TaskName = TaskCategory.None;
				Shelve = null;
			}
		}
	}
}
