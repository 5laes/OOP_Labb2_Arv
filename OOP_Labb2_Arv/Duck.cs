using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Duck : Animal
    {
        public bool hasSpots;

        public Duck(string name, int age, int happiness, string sound, string color, bool hasSpots)
        {
            this.name = name;
            this.age = age;
            this.happiness = happiness;
            this.sound = sound;
            this.color = color;
            this.hasSpots = hasSpots;
        }

        public Duck() : this("No Name", 0, 0, "No Sound", "No Color", 0)
        {

        }

        public void CheckColor()
        {
            if (hasSpots == true)
            {
                Console.Write($"\n\t{name} är {color} och har prickar på sig.");
            }
            else
            {
                Console.Write($"\n\t{name} är {color}");
            }
        }
    }
}
