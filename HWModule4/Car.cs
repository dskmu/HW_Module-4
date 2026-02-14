using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class Car : IVehicle
    {
        public string mark { get; set; }
        public string model { get; set; }
        public string oilType { get; set; }
        
        public Car(string mark, string model, string oilType)
        {
            this.mark = mark;
            this.model = model;
            this.oilType = oilType;
        }


        public void Drive()
        {
            Console.WriteLine($"The {mark} {model} is driving.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Refueling the {mark} {model} with {oilType}.");
        }
    }
}
