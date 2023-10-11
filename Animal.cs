using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Animal
    {
        protected string _AnimalType { get; set; }
        protected string _Name { get; set; }
        protected int _Eyes { get; set; }
        protected string _Fur { get; set; }
        protected string _Teeth { get; set; }
        protected string _Tail { get; set; }
        protected string _Sound { get; set; } // public variables with some default values.

        public Animal() 
        { 
        
        }

        public Animal(string name, string type, string sound)
        {
            _Name = name;
            _AnimalType = type;
            _Sound = sound;
        }

        public void Sleep()
        {
            Console.WriteLine($"{_Name} {_AnimalType} is sleeping!");
        }

        public void Eyes()
        {
            Console.WriteLine($"{_Name} {_AnimalType} have {_Eyes} eyes.");
        }

        public void Tail()
        {
            Console.WriteLine($"{_Name} {_AnimalType} have a {_Tail}.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{_Name} {_AnimalType} {_Sound}");
        }

        public void NewAnimal() // method that will create a new animal
        {

            Console.WriteLine($"{_Name} {_AnimalType}.");
        }
    }  // diffrent methods that's shared amongs the sub-classes.
}
