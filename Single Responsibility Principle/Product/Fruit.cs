using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Product
{
    public record Fruit
    {
        public Fruit(int ıd, string name, float price)
        {
            _Id = ıd;
            _Name = name;
            _Price = price;
        }

        private int _Id { get; set; }
        private string _Name { get; set; }
        private float _Price { get; set; }

        public float Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        } 
    }
}
