using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            SUV fourRunner = new SUV()
            {
                IsBasedOffTruckChassis = true,
                HasCargoArea = true,
                NumberOfWheels = 4,
                HasSteeringWheel = true,
                HasExhaustPipe = true,
                NumberOfHeadlights = 2,
                Name = "Toyota",
                Country = "Japan",
            };


            fourRunner.DisplayDetails();
            Console.WriteLine();

            Truck tacoma = new Truck()
            {
                HasBed = true,
                BedOpenOrEnclosed = "has an option for putting a cap on the bed",
                NumberOfWheels = 4,
                HasSteeringWheel = true,
                HasExhaustPipe = true,
                NumberOfHeadlights = 2,
                Name = "Toyota",
                Country = "Japan",
            };

            tacoma.DisplayDetails();
            Console.WriteLine();

            Car elentra = new Car()
            {
                HasTrunk = true,
                IsHatchback = false,
                NumberOfWheels = 4,
                HasSteeringWheel = true,
                HasExhaustPipe = true,
                NumberOfHeadlights = 2,
                Name = "Hyundai",
                Country = "South Korea",
            };

            elentra.DisplayDetails();
            Console.WriteLine();


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
