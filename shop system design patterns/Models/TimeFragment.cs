using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.Models
{
	class TimeFragment
	{
		public int? TimeLeft { get; set; }
		public TaskCategory TaskName { get; set; }

		public void StartTimeFragment(int duration, TaskCategory taskName)
		{
			TimeLeft = duration;
			TaskName = taskName;
		}

		public void Update()
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
