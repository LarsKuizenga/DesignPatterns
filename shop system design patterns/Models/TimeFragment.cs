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

		public void StartTimeFragment(int duration)
		{
			TimeLeft = duration;
		}

		public void Update()
		{
			if(TimeLeft > 0)
				TimeLeft--;

			if (TimeLeft == 0)
				TimeLeft = null;
		}
	}
}
