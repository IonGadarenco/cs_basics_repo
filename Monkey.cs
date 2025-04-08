using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal class Monkey : Animal
    {
        public Monkey(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, oa oa oa!");
        }

        public override object Clone()
        {
            return new Monkey(Name, Age);
        }
    }
}
