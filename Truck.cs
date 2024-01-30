using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    internal class Truck : Vehicle
    {
        /// <summary>
        /// This property is specific to trucks
        /// </summary>
        public int CargoCapacity { get; set; }

        /// <summary>
        /// Parameterized constructor to initialize the truck attributes
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="rentalRate"></param>
        /// <param name="cargoCapacity"></param>
        public Truck(int vehicleId, string make, string model, int year, double rentalRate, int cargoCapacity)
            : base(vehicleId, make, model, year, rentalRate)
        {
            CargoCapacity = cargoCapacity;
        }

        /// <summary>
        /// This method displays the Truck related information to the console
        /// </summary>
        public void DisplayTruckInfo()
        {
            Console.WriteLine(" - - Truck Details - - ");
            Console.WriteLine();
            Console.WriteLine($"Id: {VehicleId}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Rate: {RentalRate}");
            Console.WriteLine($"Cargo Capacity: {CargoCapacity} lbs");
            Console.WriteLine();
        }
    }
}
