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
            };

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
                
            }
            //Animal animal = new Animal("Bosse", "The Bird", "roars.");
            //Dog jackDog = new JackRussell();
            //Dog retriverDog = new GoldenRetriver();
            //Dog dog = new Dog();
            //Cat cat = new Cat();
            //Rat rat = new Rat();  

            //animal.MakeSound();
            //Console.WriteLine();

            //jackDog.MakeSound();
            //jackDog.DogChases();
            //Console.WriteLine();

            //retriverDog.MakeSound();
            //retriverDog.DogChases();
            //Console.WriteLine();

            //dog.MakeSound();
            //dog.DogChases();
            //Console.WriteLine();

            //cat.MakeSound();
            //cat.CatJumps();
            //Console.WriteLine();

            //rat.MakeSound();
            

             // Calls the diffrent methods from the objects and it's new values.
        }
    }
}