using System;

namespace OOP_Labb2_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar objekt av alla klasser
            Dog dog = new Dog("Ringo", 7, 10, "Woof", "orange", 15);
            Duck duck = new Duck("Kalle", 8, 8, "Quack", "vit", true);
            Spider spider = new Spider("Boris", 1, 6, "Hisss", "Röd", false);
            Chihuahua chihuahua = new Chihuahua("Saga", 8, 11, "Aawoooo", "svart", 8, true);
            GreatDane greatDane = new GreatDane("Scooby", 15, 25, "Rohroh", "brun", 30, false);

            //kallar på alla metoder "Dog" klassen har
            dog.MakeSound();
            dog.PetAnimal();
            dog.CheckAge();
            dog.CheckWeight();
            Console.WriteLine();

            //kallar på alla metoder "Duck" klassen har
            duck.MakeSound();
            duck.PetAnimal();
            duck.CheckAge();
            duck.CheckColor();
            Console.WriteLine();

            //kallar på alla metoder "Spider" klassen har
            spider.MakeSound();
            spider.PetAnimal();
            spider.CheckAge();
            spider.CheckPoison();
            Console.WriteLine();

            //kallar på alla metoder "Chihuahua" klassen har
            chihuahua.MakeSound();
            chihuahua.PetAnimal();
            chihuahua.CheckAge();
            chihuahua.CheckWeight();
            chihuahua.CheckShake();
            Console.WriteLine();

            //kallar på alla metoder "GreatDane" klassen har
            greatDane.MakeSound();
            greatDane.PetAnimal();
            greatDane.CheckAge();
            greatDane.CheckWeight();
            greatDane.CheckSleep();
            Console.ReadLine();
        }
    }
}
