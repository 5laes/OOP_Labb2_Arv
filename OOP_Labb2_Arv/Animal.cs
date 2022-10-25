using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    //Basklass för alla djur
    public class Animal
    {
        public string name;
        public int age;
        public int happiness;
        public string sound;
        public string color;

        public void MakeSound()
        {
            Console.Write($"\n\t{sound}!");
        }
        public void PetAnimal()
        {
            happiness++;
            Console.Write($"\n\tDu klappade {name} och hen blev gladare!" +
                $"\n\t{name}s lycka är nu {happiness}");
        }
        public void CheckAge()
        {
            Console.Write($"\n\t{name} är {age} år gammal.");
        }
    }
}
