using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Spider : Animal
    {
        public bool isPoisonous;

        //Konstruktor för att skapa ett object av "Spider"
        public Spider(string name, int age, int happiness, string sound, string color, bool isPoisonous)
        {
            this.name = name;
            this.age = age;
            this.happiness = happiness;
            this.sound = sound;
            this.color = color;
            this.isPoisonous = isPoisonous;
        }

        //En default konstruktor overload
        public Spider() : this("No Name", 0, 0, "No Sound", "No Color", false)
        {

        }

        public void CheckPoison()
        {
            if (isPoisonous == true)
            {
                Console.Write($"\n\t{name} är en giftig spindel");
            }
            else
            {
                Console.Write($"\n\t{name} är inte en giftig spindel");
            }
        }
    }
}
