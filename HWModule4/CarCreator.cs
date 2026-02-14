using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class CarCreator : VehicleCreator
    {
       public string model { get; set; }
       public string mark { get; set; }
       public string oilType { get; set; }
       public CarCreator(string mark, string model, string oilType)
       {
            this.mark = mark;
            this.model = model;
            this.oilType = oilType;
       }
        
        public override IVehicle CreateVehicle()
        {
            return new Car(mark, model, oilType);
        }
    }
}
