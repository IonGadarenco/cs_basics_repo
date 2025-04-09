using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal abstract class Animal : ICloneable
    {
        private string _food;
        private decimal _quantity;
        private string _medicines = "nothing";
        public bool hasFoodInfo = false;
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

        public void setFeedingInfo(string food, decimal quantity)
        {
            hasFoodInfo = true;
            _food = food;
            _quantity = quantity;
            Console.WriteLine("Food info is set up!");
        }

        public void setFeedingInfo(string food, decimal quantity, string medicines)
        {
            hasFoodInfo = true;
            _food = food;
            _quantity = quantity;
            _medicines = medicines;
            Console.WriteLine("Food info is set up!");
        }

        public void getFoodInfo(Animal animal)
        {
            Console.WriteLine($"{animal.Name} eat {_quantity}kg of {_food}, and {_medicines} for medicines!");
        }

        public abstract object Clone();
    }
}
