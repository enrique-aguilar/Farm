using System;

namespace CreatingAFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sheep terry = new Sheep();
                terry.Name = "Terry";

                Horses seabiscuit = new Horses();
                seabiscuit.Name = "Seabiscuit";

                Chicken albertEggstein = new Chicken();
                albertEggstein.Name = "Albert Eggstein";

                Cow bessie = new Cow();
                bessie.Name = "Bessie";

                terry.Speak();
                Console.WriteLine();
                seabiscuit.Eat();
                Console.WriteLine();
                albertEggstein.Use();
                Console.WriteLine();
                bessie.InterestingFact();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
