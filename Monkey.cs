using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal class Monkey : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, oa oa oa!");
        }

    }
}
