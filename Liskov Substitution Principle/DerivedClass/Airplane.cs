using Liskov_Substitution_Principle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.DerivedClass
{
    public class Airplane : IDrivable, IFlyable
    {
        public static void Drive() => Console.WriteLine("Airplane is drivable");
        public static void Fly() => Console.WriteLine("Airplane can fly");
    }
}
