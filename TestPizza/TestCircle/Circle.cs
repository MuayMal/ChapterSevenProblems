using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircle
{
    class Circle
    {
        private double area;
        private double diameter;
        private double radius;

        public Circle ()
        {
            radius = 1;

        }
    

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
                diameter = radius * 2;
                area = Math.PI * radius * radius;
            }

        }
        public double Area
        {
            get
            {
                return area;
            }

        }

        public double Diameter
        {
            get
            {
                return diameter;
            }

        }

        
    }
}
