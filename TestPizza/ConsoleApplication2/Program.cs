using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            HousePlants houseplant, houseplant1, houseplant2;
            houseplant = new HousePlants();
            houseplant1 = new HousePlants();
            houseplant2 = new HousePlants();

            houseplant.Name = "Philodendron";
            houseplant.Price = 29.99;
            houseplant.Fed = true;

            houseplant1.Name = "Rose";
            houseplant1.Price = 49.99;
            houseplant1.Fed = true;

            houseplant2.Name = "Violet";
            houseplant2.Price = 34.99;
            houseplant2.Fed = false;


            Console.WriteLine(houseplant.Name);
            Console.WriteLine(houseplant.Price);
            Console.WriteLine(houseplant.Fed);

            Console.WriteLine();

            Console.WriteLine(houseplant1.Name);
            Console.WriteLine(houseplant1.Price);
            Console.WriteLine(houseplant1.Fed);

            Console.WriteLine();

            Console.WriteLine(houseplant2.Name);
            Console.WriteLine(houseplant2.Price);
            Console.WriteLine(houseplant2.Fed);
        }
    }
}
