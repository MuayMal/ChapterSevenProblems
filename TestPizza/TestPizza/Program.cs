using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {


            Pizza pizza = new Pizza(12);
            pizza.Name = "Pepperoni";

            double d = pizza.Diameter;
            double p = pizza.Price;


            
            Console.Write("{0}in ",d);
            Console.WriteLine(pizza.Name);
            Console.WriteLine(p);
        }
    }
}
