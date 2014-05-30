using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquare
{
    class Square
    {
         private double area;
         private int side;

         public Square(int length)
         {
             side = length;
             area = length * length;
         }

         public int Side
         {
             get
             {
                 return side;
             }
             

             
         }

        public double Area
        {
            get
            {
                return area;
            }

            

        }
       
    }
}
