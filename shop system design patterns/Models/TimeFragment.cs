using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
	class TimeFragment
	{
		public uint? TimeLeft { get; set; }
		public TaskCategory TaskName { get; set; }

		public void StartTimeFragment(uint duration, TaskCategory taskCategory)
		{
			TimeLeft = duration;
			TaskName = taskCategory;
		}

		public void Tick()
		{
			if(TimeLeft > 0)
				TimeLeft--;

			if (TimeLeft == 0)
			{
				TimeLeft = null;
				TaskName = TaskCategory.None;
			}
		}
	}
}
