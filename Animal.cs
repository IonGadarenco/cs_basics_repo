using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal abstract class Animal : ICloneable
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age) 
        { 
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }

        public abstract object Clone();
    }
}
