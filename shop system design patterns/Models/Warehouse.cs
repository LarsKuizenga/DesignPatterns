using FrenchutoShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrenchutoShop.Models
{
    /// <summary>
    /// Storage class which allows stockers to take products from when restocking shelves.
    /// </summary>
    class Warehouse : Storage
    {
        public static int MinAmountOfProducts { get; set; } = 8;

        public Product TakeProduct(ProductCategory productCategory)
        {
            if (HasProductAmount(productCategory))
            {
                Product product = Products.First(p => p.Category == productCategory);
                Products.Remove(product);
                return product;
            }
            return null;
        }

        public bool HasProductAmount(ProductCategory productCategory, int desired = 0)
        {
            int amountOfCategory = Products.FindAll(p => p.Category == productCategory).Count;
            if (amountOfCategory > desired)
            {
                return true;
            }
            return false;
        }

        public List<string> Update()
        {
            List<string> stringList = new();

            foreach (ProductCategory productCategory in (ProductCategory[])Enum.GetValues(typeof(ProductCategory)))
            {
                if (!HasProductAmount(productCategory, MinAmountOfProducts))
                {
                    for (int i = 0; i < MinAmountOfProducts; i++)
                    {
                        Products.Add(new Product(productCategory));
                    }
                    stringList.Add($"{MinAmountOfProducts} {productCategory}s have been added to the warehouse");
                }
            }
            return stringList;
        }
    }
}
