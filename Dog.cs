using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Dog : Animal
    {
        public string _Chase { get; set; } // new variable for just this sub-class without any default values.

        public Dog()
        {
            Mammal = true;
            _Eyes = 2;
            _Fur = "short fur";
            _Teeth = "sharp teeth";
            _Sound = "barks!";
            _Tail = "curvy tail";
            _Name = "Doggy";
            _AnimalType = "The Dog";
            _Chase = "chases!";
        }

        public void TheDog() // new method that holds new variable values from the base-class and methods from the base-class.
        {
            Sleep();
            Eyes();
            Tail();
            MakeSound();
            DogChases();
        }
        public virtual void DogChases() // unique method for just this sub-class but is shared to it's sub-classes. Can be overrided aswell due to "virtual".
        {

            Console.WriteLine($"{_Name} {_AnimalType} {_Chase}");
        }
    }
}
