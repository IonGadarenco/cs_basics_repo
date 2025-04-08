namespace cs_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal rex = new Dog();
            rex.Name = "Rex";
            rex.Age = 5;
            rex.MakeSound();
            rex.Eat();

            Animal gerge = new Monkey();
            gerge.Name = "George";
            gerge.Age = 3;
            gerge.MakeSound();
            gerge.Eat();
        }
    }
}
