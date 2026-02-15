using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class Bus : IVehicle
    {
        public int capacity { get; set; }
        public string color { get; set; }

        public Bus (int capacity, string color)
        {
            this.capacity = capacity;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"The {color} bus with a capacity of {capacity} is driving.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Refueling the {color} bus with a capacity of {capacity}.");
        }
    }
}
