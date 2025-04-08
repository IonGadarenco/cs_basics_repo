using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal abstract class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }
    }
}
