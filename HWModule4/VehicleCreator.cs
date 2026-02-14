using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal abstract class VehicleCreator
    {
        public abstract IVehicle CreateVehicle();

        public void Start()
        {
            var vehicle = CreateVehicle();
            vehicle.Drive();
            vehicle.Refuel();
        }
    }
}