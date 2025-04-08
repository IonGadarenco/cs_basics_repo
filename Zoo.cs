using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_basics
{
    internal class Zoo : IEnumerable<Animal>
    {
        private string? _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value == null)
                    _name = "Some animal name";
                else
                    _name = value;
            }
        }

        private List<Animal> animals = new();

        public void AddAnimal(Animal animal) 
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal) 
        {
            animals.Remove(animal);
        }

        public IEnumerator<Animal> GetEnumerator() 
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
