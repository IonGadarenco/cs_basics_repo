using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, gaf gaf gaf!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}, eat bones!");
        }
    }
}
