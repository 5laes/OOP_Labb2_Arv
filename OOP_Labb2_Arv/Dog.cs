using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Dog : Animal 
    {
        public int weight;

        public Dog(string name, int age, int happiness, string sound, string color, int weight)
        {
            this.name = name;
            this.age = age;
            this.happiness = happiness;
            this.sound = sound;
            this.color = color;
            this.weight = weight;
        }

        public void CheckWeight()
        {
            Console.Write($"\n\t{name} väger {weight}kg");
        }
    }
}
