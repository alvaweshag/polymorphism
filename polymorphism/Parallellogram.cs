using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Parallellogram : Geometri
    {
        private readonly int bottom;
        private readonly int height;

        // constructor with a default value
        public Parallellogram()
        {
            bottom = 3;
            height = 32;
        }

        // method that overrides the method from base class
        public override double Area()
        {
            return bottom * height;
        }
    }
}
