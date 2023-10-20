using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Rat : Animal
    {
        string _EatChesse { get; set; } // new variable for just this sub-class without any default values.

        public Rat()
        {
            _Wild = true;
            Mammal = true;
            _Eyes = 2;
            _Fur = "dirty fur";
            _Teeth = "nawing teeth";
            _Sound = "squeeks!";
            _Tail = "short tail";
            _Name = "Wessel";
            _AnimalType = "The Rat"; 
            _EatChesse = "eats chesse!";
        }

        public void TheRat() // new method that holds new variable values from the base-class and methods from the base-class.
        {
            Sleep();
            Eyes();
            Tail();
            MakeSound();
            ChesseEater();
        }
        public void ChesseEater() // unique method for just this sub-class
        {
            Console.WriteLine($"{_Name} {_AnimalType} {_EatChesse}");
        }
    }
}
