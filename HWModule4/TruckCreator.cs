using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class TruckCreator : VehicleCreator
    {
        public int liftCapacity { get; set; }
        public int axes { get; set; }
        public TruckCreator(int liftCapacity, int axes)
        {
            this.liftCapacity = liftCapacity;
            this.axes = axes;
        }
        public override IVehicle CreateVehicle()
        {
            return new Truck(liftCapacity, axes);
        }
    }
}
