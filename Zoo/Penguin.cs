using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Penguin : Animal
    {
        public int KmPerHourInWater { get; set; }

            public Penguin (string name, int age, string species, int height, string characteristics, 
                string food, string sound, int kmPerHour, int kmPerHourInWater) 
                : base(name, age, species, height, characteristics, food, sound, kmPerHour)
        {
            KmPerHourInWater = kmPerHourInWater;
        }

        public void DenseBones()
        {
            Console.WriteLine("Yup, they are birds that can swim, since their bones aren't hollow.");
        }

    }
}
