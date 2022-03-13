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
		public TimeFragment TimeFragment { get; set; }

		public StockerProduct(string name) : base(name)
		{
		}

        public abstract string Stocking();

		public void Update()
		{
			TimeFragment.Update();
		}

        public override void Purchase()
		{

		}
	}
}
