using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle, circle1, circle2;
            circle = new Circle();
            circle1 = new Circle();
            circle2 = new Circle();

            circle.Radius = 1;
            circle1.Radius = 2;


            Console.WriteLine("Area: {0}",circle.Area);
            Console.WriteLine("Diametercircle.Diameter);
            Console.WriteLine(circle.Radius);

            Console.WriteLine();

            Console.WriteLine(circle1.Area);
            Console.WriteLine(circle1.Diameter);
            Console.WriteLine(circle1.Radius);

            Console.WriteLine();

            Console.WriteLine(circle2.Area);
            Console.WriteLine(circle2.Diameter);
            Console.WriteLine(circle2.Radius);
            


        }
    }
}
