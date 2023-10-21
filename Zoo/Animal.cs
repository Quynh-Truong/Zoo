using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public int Height { get; set; }
        public string Characteristics { get; set; }

        public string Food { get; set; }
        public string Sound { get; set; }

        public int KmPerHour { get; set; } 

        public Animal(string name, int age, string species, int height, string characteristics, string food, string sound, int kmPerHour)
        {
            Name = name;
            Age = age;
            Species = species;
            Height = height;
            Characteristics = characteristics;
            Food = food;
            Sound = sound;
            KmPerHour = kmPerHour;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name}'s preferred choice of sustenance is {Food}.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"The {Species} will sound like \"{Sound}\"");
        }

        public void HowFast()
        {
            Console.WriteLine($"{Name} can reach a speed of {KmPerHour} km per hour.");
        }

    }
}
