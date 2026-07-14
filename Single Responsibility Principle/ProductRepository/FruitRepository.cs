using Single_Responsibility_Principle.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.ProductRepository;

public class FruitRepository
{
    public List<Fruit> products = new List<Fruit>()
    {
        new Fruit(1, "Apple", 2.5f),
        new Fruit(2, "Pear", 3.0f),
        new Fruit(3, "Banana", 1.8f),
        new Fruit(4, "Orange", 2.2f),
        new Fruit(5, "Blueberry", 4.0f)
    };

    public FruitRepository()
    {

    }
}