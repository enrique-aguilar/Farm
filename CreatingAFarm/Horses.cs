using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingAFarm
{
    public class Horses
    {
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a horse. I say 'NEIGH'");
        }
        public void Eat()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a horse. I eat grass.");
        }
        public void Use()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a horse. I'm used for riding and transportation.");
        }
        public void InterestingFact()
        {
            Console.WriteLine($"Hi, my name is {Name}. I'm a horse. I can sleep lying down or standing up!");
        }
    }
}
