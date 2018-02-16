using System;
using AnimalKingdom;

namespace AssignmentWk5
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal[] { 
                new Dog("Barnie", 37M), new Cat("Stacy", 22M), new Cat("Charlie", 29M),
                new Dog("Woopy", 45M), new Dog("Scooby", 44M), new Cat("Garfield", 77M)
            };

            System.Console.WriteLine("\n=======================================");
            System.Console.WriteLine("Prting All Animals In the Animal Kingdom");
            System.Console.WriteLine("That are Cats and Dogs");
            System.Console.WriteLine("=======================================\n");
            foreach (var animal in animals)
            {
                animal.Speak();
                animal.Move();
                System.Console.WriteLine(animal.ToString());
                System.Console.WriteLine("\n=======================================\n");
            }
        }
    }
}
