using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Frog : Animal
    {
        public string Enemy { get; set; }
        public Frog (string name, int age, string species, int height, string characteristics,
                string food, string sound, int kmPerHour, string enemy)
                : base(name, age, species, height, characteristics, food, sound, kmPerHour)
        {
            Enemy = enemy;
        }
        public void SuperEyes()
        {
            Console.WriteLine("Frogs have excellent (night) vision and use their eyes to push down their meal.");
        }
    }
}
