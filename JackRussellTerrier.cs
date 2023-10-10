using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class JackRussell : Dog // new sub-class that got "Dog" as it's "base-class"
    {
        public override void DogChases() // method that overrides the base-class method.
        {
            name = "Jack";
            animalType = "The Jack Russell";
            chase = "chases!";
            Console.WriteLine($"{name} {animalType} {chase}");
        }
    }
}
