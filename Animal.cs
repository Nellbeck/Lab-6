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

    public class Cat : Animal
    {
        public string jumps { get; set; } // new variable for just this sub-class without any default values.

        public void TheCat() // new method that holds new variable values from the base-class and methods from the base-class.
        {
            fur = "soft fur";
            teeth = "sparkling teeth";
            sound = "purrs!";
            tail = "fluffy tail";
            name = "Frazze";
            animalType = "The Cat";

            newAnimal(name, animalType);
            Sleep();
            Eyes();
            Tail();
            makeSound();
            CatJumps();
        }

        public void CatJumps() // unique method for just this sub-class
        {
            jumps = "jumps!";
            Console.WriteLine($"{name} {animalType} {jumps}");

        }
    }

    public class Dog : Animal
    {
        public string chase { get; set; } // new variable for just this sub-class without any default values.


        public void TheDog() // new method that holds new variable values from the base-class and methods from the base-class.
        {
            fur = "short fur";
            teeth = "sharp teeth";
            sound = "barks!";
            tail = "curvy tail";
            name = "Doggy";
            animalType = "The Dog";

            Sleep();
            Eyes();
            Tail();
            makeSound();
            DogChases();
        }
        public virtual void DogChases() // unique method for just this sub-class but is shared to it's sub-classes. Can be overrided aswell due to "virtual".
        {
            chase = "chases!";
            Console.WriteLine($"{name} {animalType} {chase}");
        }
    }

    class JackRussell : Dog // new sub-class that got "Dog" as it's "base-class"
    {
        public override void DogChases() // method that overrides the base-class method.
        {
            name = "Jack";
            animalType = "The Jack Russell";
            chase = "chases!";
            Console.WriteLine($"{name} {animalType} {chase}");
        }
    }

    class GoldenRetriver : Dog // new sub-class that got "Dog" as it's "base-class"
    {
        public override void DogChases() // method that overrides the base-class method.
        {
            name = "Hubby";
            animalType = "The Golden Retriever";
            chase = "chases!";
            Console.WriteLine($"{name} {animalType} {chase}");
        }
    }

    class Rat : Animal
    {
        string eatChesse { get; set; } // new variable for just this sub-class without any default values.

        public void TheRat() // new method that holds new variable values from the base-class and methods from the base-class.
        {
            fur = "dirty fur";
            teeth = "nawing teeth";
            sound = "squeeks!";
            tail = "short tail";
            name = "Wessel";
            animalType = "The Rat";

            Sleep();
            Eyes();
            Tail();
            makeSound();
            ChesseEater();
        }
        public void ChesseEater() // unique method for just this sub-class
        {
            eatChesse = "eats chesse!";
            Console.WriteLine($"{name} {animalType} {eatChesse}");
        }
    }
}
