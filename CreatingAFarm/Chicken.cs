using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingAFarm
{
    public class Chicken
    {
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a chicken. I say 'BUCOOOOOCK'");
        }
        public void Eat()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a chicken. I eat centipedes.");
        }
        public void Use()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a chicken. I'm used for meat and eggs.");
        }
        public void InterestingFact()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a chicken. I can remember about over 100 different faces of people or animals!");
        }
    }
}
