using System.Diagnostics;

namespace Lab_6
{
    
    
       
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog jackDog = new JackRussell();
            Dog retriverDog = new GoldenRetriver();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Rat rat = new Rat(); 

            animal.makeSound();
            Console.WriteLine();

            animal.newAnimal("Bosse","Bird");
            Console.WriteLine();

            jackDog.DogChases();
            Console.WriteLine();

            retriverDog.DogChases();
            Console.WriteLine();

            dog.TheDog();
            Console.WriteLine();

            cat.TheCat();
            Console.WriteLine();

            rat.TheRat(); // Calls the diffrent methods and it's new values.
        }
    }
}