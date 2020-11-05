using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal 
    {
        public Animal()
        {
            
        }
        public string AnimalName { get; set; }
        public bool CanSwim { get; set;  }
        public string HairType { get; set; }
        public bool HasSpine { get; set; }
        public int Legs { get; set; }
    }
}
