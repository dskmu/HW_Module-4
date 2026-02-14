using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class Truck : IVehicle
    {
        public int liftCapacity { get; set; }
        public int axes { get; set; }

        public Truck(int liftCapacity, int axes)
        {
            this.liftCapacity = liftCapacity;
            this.axes = axes;
        }


        public void Drive()
        {
            Console.WriteLine($"The truck with lift capacity of {liftCapacity} tons and {axes} axes is driving.");
        }
        public void Refuel()
        {
            Console.WriteLine($"Refueling the truck with lift capacity of {liftCapacity} tons and {axes} axes with diesel.");
        }
    }
}
