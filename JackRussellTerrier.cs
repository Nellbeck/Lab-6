using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class JackRussell : Dog // new sub-class that got "Dog" as it's "base-class"
    {
        public JackRussell()
        {
            _Name = "Jack";
            _AnimalType = "The Jack Russell";
            _Chase = "chases his tail";
        }
        public override void DogChases() // method that overrides the base-class method.
        {
            Console.WriteLine($"{_Name} {_AnimalType} {_Chase} inside a car.");
        }
    }
}
