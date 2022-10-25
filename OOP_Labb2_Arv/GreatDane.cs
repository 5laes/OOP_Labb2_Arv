using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class GreatDane : Dog
    {
        public bool isSleeping;

        //Konstruktor för att skapa ett object av "GreatDane"
        public GreatDane(string name, int age, int happiness, string sound, string color, int weight, bool isSleeping)
            : base(name, age, happiness, sound, color, weight)
        {
            this.name = name;
            this.age = age;
            this.happiness = happiness;
            this.sound = sound;
            this.color = color;
            this.weight = weight;
            this.isSleeping = isSleeping;
        }

        //En default konstruktor overload
        public GreatDane() : this("No Name", 0, 0, "No Sound", "No Color", 0, false)
        {

        }

        public void CheckSleep()
        {
            if (isSleeping == true)
            {
                Console.Write($"\n\t{name} sover shhh.");
            }
            else
            {
                Console.Write($"\n\t{name} är vaken!");
            }
        }
    }
}
