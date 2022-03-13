using shop_system_design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    abstract class StockerProduct : Person
    {
		public bool IsStocking { get; set; }
		
		public StockerProduct(string name) : base(name)
		{
		}

        public abstract string Stocking();

        public override string Purchase(ProductCategory productCategory)
		{
			if(TimeFragment.TaskName != TaskCategory.Purchasing)
			{
				return $"{Name} is a {GetType().Name[0..^7]} and his doing their job right now, no shopping!";
			}
			if (TimeFragment.TimeLeft == null)
			{
				//TODO: Determine timefragments per task
				TimeFragment.StartTimeFragment(1, TaskCategory.Stocking);
			}
			return $"Buying some {productCategory}'s (with a discount!) for another {TimeFragment.TimeLeft} minutes";
		}
	}
}
