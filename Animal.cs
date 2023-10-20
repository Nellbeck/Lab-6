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
        protected string _Sound { get; set; } // protected propertys that every sub-class inheritance.
        private bool _Mammal { get; set; }
        public bool _Wild { get; set; }
        public bool Mammal
        {
            get { return _Mammal; }
            set { _Mammal = value; }
        }

        public Animal() 
        { 
        
        }

        public Animal(string name, string type, string sound, bool mammal, bool wild)
        {
            _Wild = wild;
            _Mammal = mammal;
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

    }  // diffrent methods that's shared amongs the sub-classes.
}
