using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Chihuahua : Dog
    {
        public bool isShaking;
        public Chihuahua(string name, int age, int happiness, string sound, string color, int weight, bool isShaking) 
            : base(name, age, happiness, sound, color, weight)
        {
            this.name = name;
            this.age = age;
            this.happiness = happiness;
            this.sound = sound;
            this.color = color;
            this.weight = weight;
            this.isShaking = isShaking;
        }

        public Chihuahua() : this("No Name", 0, 0, "No Sound", "No Color", 0, false)
        {

        }

        public void CheckShake()
        {
            if (isShaking == true)
            {
                Console.Write($"\n\t{name} skakar.");
            }
            else
            {
                Console.Write($"\n\t{name} skakar inte.");
            }
        }
    }
}
