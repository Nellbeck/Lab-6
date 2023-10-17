using System.Diagnostics;
/*
 * Fredrik Nellbeck
 * .NET23_OOP
 * Systemutveckling.NET med AI-kompetens
*/
namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Bosse", "The Bird", "roars.");
            Dog jackDog = new JackRussell();
            Dog retriverDog = new GoldenRetriver();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Rat rat = new Rat();  

            animal.MakeSound();
            Console.WriteLine();

            jackDog.MakeSound();
            Console.WriteLine();

            retriverDog.MakeSound();
            Console.WriteLine();

            dog.MakeSound();
            Console.WriteLine();

            cat.MakeSound();
            Console.WriteLine();

            rat.MakeSound();

             // Calls the diffrent methods and it's new values.
        }
    }
}