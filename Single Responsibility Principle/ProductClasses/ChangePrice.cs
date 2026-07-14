using Single_Responsibility_Principle.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.ProductClasses
{
    public class ChangePrice
    {
        public static void ChangeFruitPrice(int id, List<Fruit> fruits, float price)
        {
            fruits[id].Price = price;
        }
    }
}
