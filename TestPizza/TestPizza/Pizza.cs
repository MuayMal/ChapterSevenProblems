using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pizza
    {
        private double diameter;
        private double price;
        private string topping;


        public Pizza(double diameter)
        {
            this.diameter = diameter;
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }

            set
            {
                diameter = value;
            }
        }
        public string Name
        {
            get
            {
                return topping;
            }
            set
            {
                topping = value;
            }
             
        }

        public double Price
        {
            get
            {
                return price = 13.99;
            }

            set
            {
                price = value;
            }
        }

    }
}
