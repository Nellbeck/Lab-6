using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
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
}
