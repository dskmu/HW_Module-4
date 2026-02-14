using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule4
{
    internal class Motorcycle : IVehicle
    {
        public string type { get; set; }
        public string volume { get; set; }
        
        public Motorcycle(string type, string volume)
        {
            this.type = type;
            this.volume = volume;
        }
        public void Drive()
        {
            Console.WriteLine($"The {type} {volume} is driving.");
        }
        
        public void Refuel()
        {
            Console.WriteLine($"Refueling the {type} {volume} with gasoline.");
        }
    }
}
