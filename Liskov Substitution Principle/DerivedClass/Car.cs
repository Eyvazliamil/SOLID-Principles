using Liskov_Substitution_Principle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.DerivedClass
{
    public class Car : IDrivable
    { 
        public static void Drive() => Console.WriteLine("Car is drivable");
    }
}
