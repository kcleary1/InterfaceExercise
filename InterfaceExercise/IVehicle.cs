using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool HasSteeringWheel {  get; set; }
        public bool HasExhaustPipe { get; set; }
        public int NumberOfHeadlights { get; set; }

        public void DisplayDetails();
    }
}
