namespace cs_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal rex = new Dog();
            //rex.Name = "Rex";
            //rex.Age = 5;
            //rex.MakeSound();
            //rex.Eat();

            //Animal gerge = new Monkey();
            //gerge.Name = "George";
            //gerge.Age = 3;
            //gerge.MakeSound();
            //gerge.Eat();

            Zoo zoo = new Zoo();
            zoo.Name = "ZooLandia";
            zoo.AddAnimal(new Dog("Rex", 5));
            zoo.AddAnimal(new Monkey("George", 2));

            Animal dog = new Dog("Muhtar", 10);
            dog.setFeedingInfo("meet", 0.3m, "paracetamol");
            zoo.AddAnimal(dog);

            foreach (var animal in zoo)
            {
                Console.WriteLine("*********************");
                animal.MakeSound();
                animal.Eat();
                if (animal.HasFoodInfo)
                    animal.getFoodInfo(animal);

                var clonedAnimal = animal.Clone() as Animal;
                Console.WriteLine($"Cloned {clonedAnimal.Name}, age {clonedAnimal.Age}, in {zoo.Name}");
            }
        }
    }
}
