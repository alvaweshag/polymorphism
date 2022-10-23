using System;

namespace polymorphism
{   // Alva Westrin Haglund .NET22
    class Program
    {    
        static void Main(string[] args)
        {   // prints out a squares area
            Fyrkant fyrkant = new Fyrkant();
            Console.WriteLine("Fyrkant: " + fyrkant.Area());

            // prints out a rectangles area
            Rektangel rektangel = new Rektangel();
            Console.WriteLine("Rektangel: " + rektangel.Area());

            // prints out a circles area
            Cirkel cirkel = new Cirkel();
            Console.WriteLine("Cirkel: " + cirkel.Area());

            // prints out an ellips area
            Ellips ellips = new Ellips();
            Console.WriteLine("Ellips: " + ellips.Area());

            // prints out an parallelograms area
            Parallellogram parallellogram = new Parallellogram();
            Console.WriteLine("Parallellogram: " + parallellogram.Area());
        }
    }
}
