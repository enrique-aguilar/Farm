using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingAFarm
{
    public class Cow
    {
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a cow. I say 'MOOOOOOOOOO'");
        }
        public void Eat()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a cow. I eat grass.");
        }
        public void Use()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a cow. I'm used to make meat, milk and hides.");
        }
        public void InterestingFact()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a cow. My stomach has four chambers!");
        }
    }
}
