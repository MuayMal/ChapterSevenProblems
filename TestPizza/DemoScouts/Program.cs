using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
    class Program
    {
        static void Main(string[] args)
        {
           GirlScout troop, troop1, troop2;
            troop = new GirlScout();
            troop1 = new GirlScout();
            troop2 = new GirlScout();

            troop.Name = "Alpha";
            troop.Tnumber = 46826;
            troop.Dues = true;

            troop1.Name = "Bravo";
            troop1.Tnumber = 34681;
            troop1.Dues = true;

            troop2.Name = "Charlie";
            troop2.Tnumber = 47566;
            troop2.Dues = false;


            Console.WriteLine(troop.Name);
            Console.WriteLine(troop.Tnumber);
            Console.WriteLine(troop.Dues);

            Console.WriteLine();

            Console.WriteLine(troop1.Name);
            Console.WriteLine(troop1.Tnumber);
            Console.WriteLine(troop1.Dues);

            Console.WriteLine();

            Console.WriteLine(troop2.Name);
            Console.WriteLine(troop2.Tnumber);
            Console.WriteLine(troop2.Dues);

            Console.WriteLine("Our motto is: {0}",GirlScout.Motto);
        }
    }
}
