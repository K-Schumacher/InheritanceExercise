using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {
            CanSwim = false;
            HairType = "Feathers";
            HasSpine = true;
            Legs = 2;
        }

        public bool CanFly { get; set; }
        public string WingColor { get; set; }
        public string SoundProduced { get; set; }
        public bool Migrate { get; set; }
    }
}
