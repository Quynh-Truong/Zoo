using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Grizzly : Bear
    {
        public int DaysInHibernation { get; set; }

        public Grizzly(string name, int age, string species, int height, string characteristics,
                string food, string sound, int kmPerHour, int expectedAgeInCaptivity, int daysInHibernation)
                : base(name, age, species, height, characteristics, food, sound, kmPerHour, expectedAgeInCaptivity)
        {
            DaysInHibernation = daysInHibernation;
        }
        public void StrongForFood()
        {
            Console.WriteLine("They can bend open a car in order to access food.");
        }
    }
}
