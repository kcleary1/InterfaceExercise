using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck: IVehicle, ICompany
    {
        public bool HasBed {  get; set; }
        public string BedOpenOrEnclosed {  get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasSteeringWheel { get; set; }
        public bool HasExhaustPipe { get; set; }
        public int NumberOfHeadlights { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"This vehicle {(HasBed ? "has" : "does not have")} a bed for cargo transportation, and {BedOpenOrEnclosed}.");
            Console.WriteLine($"It has {NumberOfWheels} wheels, and like all vehicles, {(HasSteeringWheel ? "has" : "does not have")} a steering wheel.");
            Console.WriteLine($"In addition, an exhaust pipe {(HasExhaustPipe ? "is present" : "is not present")}. Not surprisingly, {NumberOfHeadlights} headlights are present.");
            Console.WriteLine($"Lastly, {Name} is the company producing this vehicle, and they are based out of {Country}.");


        }
    }
    
}
