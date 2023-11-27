using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Car_Engine_And_Tires
{
    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure) 
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
