using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Car_Engine_And_Tires
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity) 
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
}
