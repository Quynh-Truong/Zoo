
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Bear : Animal
    {
        public int ExpectedAgeInCaptivity { get; set; }
        public Bear(string name, int age, string species, int height, string characteristics,
                string food, string sound, int kmPerHour, int expectedAgeInCaptivity)
                : base(name, age, species, height, characteristics, food, sound, kmPerHour) 
        {
            ExpectedAgeInCaptivity = expectedAgeInCaptivity;
        }
        public void WhenABearAttacks() 
        {
            Console.WriteLine("If you face a bear attack - be smart, play dead.");
        }
    }
}

