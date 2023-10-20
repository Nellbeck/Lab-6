using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Cat : Animal
        {
            public string _Jumps { get; set; } // new variable for just this sub-class without any default values.
        public Cat()
        {
            Mammal = true;
            _Eyes = 2;
            _Fur = "soft fur";
            _Teeth = "sparkling teeth";
            _Sound = "purrs!";
            _Tail = "fluffy tail";
            _Name = "Frazze";
            _AnimalType = "The Cat";
            _Jumps = "jumps!";
        }

        public void TheCat() // new method that holds new variable values from the base-class and methods from the base-class.
            {
                Sleep();
                Eyes();
                Tail();
                MakeSound();
                CatJumps();
            }

            public void CatJumps() // unique method for just this sub-class
            {
            Console.WriteLine($"{_Name} {_AnimalType} {_Jumps}");
            }
        }
    }
