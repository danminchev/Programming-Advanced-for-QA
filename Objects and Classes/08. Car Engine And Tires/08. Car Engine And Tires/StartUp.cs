using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Car_Engine_And_Tires
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tires = new Tire[]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };

            var engine = new Engine(560, 6300);

            var lambo = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            Console.WriteLine(lambo.WhoAmI());
        }
    }
}
