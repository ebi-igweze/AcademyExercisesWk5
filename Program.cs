using System.Linq;
using Interfaces;
using Ex1 = AnimalKingdom;
using Ex2 = SecondExercise;
namespace AssignmentWk5
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Ex1.Animal[] { 
                new Ex1.Dog("Barnie", 37M), new Ex1.Cat("Stacy", 22M), new Ex1.Cat("Charlie", 29M),
                new Ex1.Dog("Woopy", 45M), new Ex1.Dog("Scooby", 44M), new Ex1.Cat("Garfield", 77M)
            };

            System.Console.WriteLine("\n=======================================");
            System.Console.WriteLine("Exercise1: Prting All Animals In the ");
            System.Console.WriteLine("Animal Kingdom That are Cats and Dogs");
            System.Console.WriteLine("=======================================\n");
            foreach (var animal in animals)
            {
                animal.Speak();
                animal.Move();
                System.Console.WriteLine(animal.ToString());
                System.Console.WriteLine("\n=======================================\n");
            }



            System.Console.WriteLine("\n=======================================");
            System.Console.WriteLine("Exercise3: Comparing Two Dog Types");
            System.Console.WriteLine("Using the object override .Equals method");
            System.Console.WriteLine("=======================================\n");
            // Implementing Exercise 3
            var dogA = new Ex2.Dog("Garfield", 23);
            var dogB = new Ex2.Dog("Garfield", 23);
            var compareResult = dogA.Equals(dogB);
            System.Console.WriteLine($"Comparing dogA = {dogA.Name}, with dogB = {dogB.Name} results to = {compareResult}");
            System.Console.WriteLine("\n=========================================\n");



            
            System.Console.WriteLine("\n=======================================");
            System.Console.WriteLine("Exercise4: Checking if a Class implements");
            System.Console.WriteLine("A given interface or sets of interfaces");
            System.Console.WriteLine("=======================================\n");
            // Implementing Exercise 4
            // Technique 1: check if Document  is IStorable & IPrintable
            var docInterfaces = typeof(Document).GetInterfaces();
            var isStorable = docInterfaces.Contains(typeof(IStorable));
            var isPrintable = docInterfaces.Contains(typeof(IPrintable));
            // Technique 2: check if Document is Storable & Printable
            var isStorable2 = typeof(IStorable).IsAssignableFrom(typeof(Document));
            var isPrintable2 = typeof(IPrintable).IsAssignableFrom(typeof(Document));

            System.Console.WriteLine("Using the first technique of checking the class interfaces:");
            System.Console.WriteLine($"The result are IStorable = {isStorable} and IPrintable = {isPrintable}");
            
            System.Console.WriteLine("\nUsing the second technique of checking if the class is assignable to the interfaces:");
            System.Console.WriteLine($"The result are IStorable = {isStorable} and IPrintable = {isPrintable}");
            System.Console.WriteLine("\n==========================================\n");
            
           


        }

    }
}
