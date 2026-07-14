using Interface_Segregation_Principle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Classes
{
    public class Animal
    { 
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal can make noise");
        }
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Dog can make noise");
        }
    }

    public class Parrot : Animal, ISpeakLikeHuman
    {
        public void SpeakLikeHuman() => Console.WriteLine("Parrot can speak like human");
        public override void MakeNoise()
        {
            Console.WriteLine("Parrot can make noise");
        }
    }
}
