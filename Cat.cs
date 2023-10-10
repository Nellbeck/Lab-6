using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
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
    }
