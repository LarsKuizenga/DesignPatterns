using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
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
			if(amountOfCategory > desired)
            {
				return true;
            }
			return false;
        }

        public List<String> Update()
        {
            List<String> stringList = new();

            foreach (ProductCategory productCategory in (ProductCategory[])Enum.GetValues(typeof(ProductCategory)))
            {
                if(!HasProductAmount(productCategory, MinAmountOfProducts))
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
