using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {
            CanSwim = true;
            HairType = "Bald headed bastards";
            HasSpine = true;
            Legs = 4;
        }

        public bool HasScales { get; set; }
        public bool HasTail { get; set; }
        public string Diet { get; set; }
        public int Fangs { get; set; }
    }
}
