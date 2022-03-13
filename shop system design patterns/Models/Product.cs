using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Product
    {
        public IComponent Component { get; set; }
        public ProductCategory Category { get; set; } 
        
        public Product(ProductCategory category)
        {
            Category = category;
            Component = CreateComponent(category);
        }

        public static IComponent CreateComponent(ProductCategory productCategory)
		{
			//TODO: Extend boxes to contain right elements
			return productCategory switch
			{
				ProductCategory.Bed => new Box()
				{
					Children =
						{
							new Box()
							{
								Children = {
									new Part("RightBedSide"),
									new Part("LeftBedSide")
								}
							},
							new Box()
							{
								Children =
								{
									new Part("Mattres")
								}
							}
						}
				},
				ProductCategory.Chair => new Box()
				{
					Children =
						{
							new Box()
							{
								Children = {
									new Part("RightChairSide"),
									new Part("LeftChairSide")
								}
							},
							new Box()
							{
								Children =
								{
									new Part("Seat")
								}
							}
						}
				},
				ProductCategory.Couch => new Box()
				{
					Children =
						{
							new Box()
							{
								Children = {
									new Part("RightCouchSide"),
									new Part("LeftCouchSide")
								}
							},
							new Box()
							{
								Children =
								{
									new Part("Couchcushion"),
									new Part("Couchcushion"),
									new Part("Couchcushion"),
									new Part("Couchcushion")
								}
							}
						}
				},
				ProductCategory.Table => new Box()
				{
					Children =
						{
							new Box()
							{
								Children = {
									new Part("RightTableSide"),
									new Part("LeftTableSide")
								}
							},
							new Box()
							{
								Children =
								{
									new Part("Tablesurface")
								}
							}
						}
				},
				_ => new Box()
				{
					Children = null
				},
			};
		}

        public string PrintName()
		{
            return Component.PrintName();
		}
    }
}
