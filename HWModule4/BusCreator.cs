using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class BusCreator : VehicleCreator
    {
        public int capacity { get; set; }
        public string color { get; set; }
        public BusCreator(int capacity, string color)
        {
            this.capacity = capacity;
            this.color = color;
        }
        public override IVehicle CreateVehicle()
        {
            return new Bus(capacity, color);
        }
    }
}
