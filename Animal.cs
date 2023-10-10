using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Animal
    {
        public string animalType = "The Horse";
        public string name = "Hasse";
        public int eyes = 2;
        public string fur = "dirty";
        public string teeth = "jagged";
        public string tail = "no tail";
        public string sound = "sounds like a human."; // public variables with some default values.

        public void Sleep()
        {
            Console.WriteLine($"{name} {animalType} is sleeping!");
        }
        public void Eyes()
        {
            Console.WriteLine($"{name} {animalType} have {eyes} eyes.");
        }
        public void Tail()
        {
            Console.WriteLine($"{name} {animalType} have a {tail}.");
        }
        public void makeSound()
        {
            Console.WriteLine($"{name} {animalType} {sound}");
        }
        public void newAnimal(string name, string type) // method that will create a new animal
        {
            Console.WriteLine($"{name} {type}.");
        }
    }  // diffrent methods that's shared amongs the sub-classes.
}
