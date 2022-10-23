using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{   // 
    class Fyrkant : Geometri
    {
        private readonly int side;

        // constructor with a default value
        public Fyrkant()
        {
            side = 3;
        }

        // method that overrides the method from base class
        public override double Area()
        {
            return side * side;
        }
    }
}
