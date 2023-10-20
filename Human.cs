using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Human : Animal
    {
        bool _Selfawarness { get; set; }
        public Human()
        {
            _Wild = false;
            Mammal = true;
            _Selfawarness = true;
            _AnimalType = "The Man";
            _Name = "Ernst";
            _Sound = "make the sound you make when you just missed the nail with you hammer and instead hit your hand. (Ouch!)";
        }
        
    }
}
