using FrenchutoShop.Models.Composite;
using FrenchutoShop.Models.Enums;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Represents a box with a specific kind of ProductCategory.
    /// </summary>
    class Product
    {
        public IComponent Component { get; set; }
        public ProductCategory Category { get; set; }

        public Product(ProductCategory category)
        {
            Category = category;
            Component = CreateComponent(category);
        }

        private static IComponent CreateComponent(ProductCategory productCategory)
        {
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
                                    new Part("FrontRightChairLeg"),
                                    new Part("FrontLeftChairLeg"),
                                    new Part("BackRightChairLeg"),
                                    new Part("BackLeftChairLeg"),
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
                                    new Part("FrontRightCouchLeg"),
                                    new Part("FrontLeftCouchLeg"),
                                    new Part("BackRightCouchLeg"),
                                    new Part("BackLeftCouchLeg"),
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
                                    new Part("FrontRightTableLeg"),
                                    new Part("FrontLeftTableLeg"),
                                    new Part("BackRightTableLeg"),
                                    new Part("BackLeftTableLeg"),
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
