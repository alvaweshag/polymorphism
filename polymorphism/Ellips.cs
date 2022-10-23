using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Ellips : Geometri
    {
        readonly int a;
        readonly int b;

        // constructor with a default value
        public Ellips()
        {
            a = 4;
            b = 2;
        }

        // method that overrides the method from base class
        public override double Area()
        {
            return b * a * Math.PI;
        }
    }
}
