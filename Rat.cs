using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
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
