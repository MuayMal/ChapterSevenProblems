using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
    class GirlScout
    {
        
        private string name;
        private double tnumber;
        private bool dues;
        public const string Motto = "to obey the Girl scout law";

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

        public double Tnumber
        {
            get
            {
                return tnumber;
            }

            set
            {
                tnumber = value;
            }
        }

        public bool Dues
        {
            get
            {
                return dues;
            }

            set
            {
               dues = value;
            }

        }
    }
}
