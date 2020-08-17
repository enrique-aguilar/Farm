using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingAFarm
{
    public class Sheep
    {
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a sheep. I say 'BAAAAAHHHHHHH'");
        }
        public void Eat()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a sheep. I eat hay.");
        }
        public void Use()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a sheep. I'm used to make fleeces, meat, and milk.");
        }
        public void InterestingFact()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a sheep. There are over 1 billion of me in the world!");
        }
    }
}
