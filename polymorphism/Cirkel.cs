using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Cirkel : Geometri
    { 
         double radius { get; set; }

        // constructor with a default value
        public Cirkel()
        {
            radius = 5;
        }

        // method that overrides the method from base class
        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
