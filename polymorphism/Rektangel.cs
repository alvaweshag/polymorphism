using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Rektangel : Geometri
    {
        private readonly int longSide;
        private readonly int shortSide;

        // constructor with a default value
        public Rektangel()
        {
            longSide = 6;
            shortSide = 3;
        }
        // method that overrides the method from base class
        public override double Area()
        {
            return longSide * shortSide;
        }
    }
}
