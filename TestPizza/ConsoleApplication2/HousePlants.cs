using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class HousePlants
    {
        private string name;
        private double price;
        private bool fed;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public bool Fed
        {
            get
            {
                return fed;
            }

            set
            {
                fed = value;
            }

        }


    }
}
