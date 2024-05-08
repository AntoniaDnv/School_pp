using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarManifacturer
{
    public class Engine
    {
        private int horesePower;
        private double cubicCapasity;

       public int HorsePower
        {
            get { return horesePower; }
            set { horesePower = value; }
        }
        public double CubicCapacities
        {
            get { return cubicCapasity; }
            set { cubicCapasity = value;}

        }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacities = cubicCapacity;

        }
    }
}
