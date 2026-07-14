using Single_Responsibility_Principle.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.ProductPrinter
{
    public class ProductInfos
    {
        public static void getProductsInfos(List<Fruit> products)
        {
            products.ForEach(product => { Console.WriteLine(product); });
        }
    }
}
