using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class GoldenRetriver : Dog // new sub-class that got "Dog" as it's "base-class"
    {
        public GoldenRetriver()
        {
            _Name = "Hubby";
            _AnimalType = "The Golden Retriever";
            _Chase = "chases a cat!";
        }
        public override void DogChases() // method that overrides the base-class method.
        {
            Console.WriteLine($"{_Name} {_AnimalType} {_Chase}");
        }
    }
}
