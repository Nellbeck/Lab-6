using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    
    internal class Snake : Animal
    {
        bool _Posionness { get; set; }
        public Snake()
        {
            _Posionness = true;
            _AnimalType = "The Snake";
            _Name = "Sir Wazz";
            _Sound = "farts.(Can a snake fart?)";
        }
    }
}
