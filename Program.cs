using System.Diagnostics;
using System.Globalization;
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
            List<Animal> animals = new List<Animal>()
            {
                new Animal("Bosse", "The Cow", "roars!", true, false),
                new JackRussell(),
                new GoldenRetriver(),
                new Dog(),
                new Cat(),
                new Rat(),
                new Human(),
                new Snake()
            }; // A list of every class and saved into the object "animals".

            foreach (var function in animals) 
            {
                if (function.Mammal && !function._Wild)
                {
                    function.MakeSound();
                    Console.WriteLine("A domestic mammal!");
                }
                else if (function.Mammal) 
                {
                    function.MakeSound();
                    Console.WriteLine("A wild mammal!");
                }

                else if (!function.Mammal && function._Wild)
                {
                    function.MakeSound();
                    Console.WriteLine("Is wild reptile.");
                }
                    Console.WriteLine();
            }// foreach loop with some if and else if statments to check if it's a mammal and/or a wild animal and run the shared method.
        }
    }
}