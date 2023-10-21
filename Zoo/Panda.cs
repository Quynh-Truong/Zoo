using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Panda : Bear
    {
        public int HoursPerDayEating { get; set; }

        public Panda(string name, int age, string species, int height, string characteristics,
                string food, string sound, int kmPerHour, int expectedAgeInCaptivity, int hoursPerDayEating)
                : base(name, age, species, height, characteristics, food, sound, kmPerHour, expectedAgeInCaptivity)
        {
            HoursPerDayEating = hoursPerDayEating;
        }
        public void CanEatMeat()
        {
            Console.WriteLine("Pandas are 99% vegans, but occasionally eats meat.");
        }
    }
}
