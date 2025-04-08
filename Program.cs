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

            foreach (var animal in zoo)
            {
                animal.MakeSound();
                animal.Eat();

                var clonedAnimal = animal.Clone() as Animal;
                Console.WriteLine($"Cloned {clonedAnimal.Name}, age {clonedAnimal.Age}, all in {zoo.Name}");
            }
        }
    }
}
