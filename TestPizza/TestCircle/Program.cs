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


            Console.WriteLine("Area: {0}",circle.Area.ToString("N"));
            Console.WriteLine("Radius: {0}", circle.Radius);
            Console.WriteLine("Diameter: {0}",circle.Diameter);
            

            Console.WriteLine();

            Console.WriteLine("Area: {0}",circle1.Area.ToString("N"));
            Console.WriteLine("Radius: {0}", circle1.Radius);
            Console.WriteLine("Diameter: {0}",circle1.Diameter);
            

            Console.WriteLine();

            Console.WriteLine("Area: {0}",circle2.Area.ToString("N"));
            Console.WriteLine("Radius: {0}", circle2.Radius);
            Console.WriteLine("Diameter: {0}",circle2.Diameter);
            
            


        }
    }
}
