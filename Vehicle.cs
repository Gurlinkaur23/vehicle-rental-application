using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    /// <summary>
    /// Vehicle is a base class which represents car or truck
    /// </summary>
    internal class Vehicle
    {
        /// <summary>
        /// Properties representing the information about the vehicle
        /// </summary>
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double RentalRate { get; set; }

        /// <summary>
        /// Parameterized constructor to initialize the attributes of the vehicle
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="rentalRate"></param>
        public Vehicle(int vehicleId, string make, string model, int year, double rentalRate)
        {
            VehicleId = vehicleId;
            Make = make;
            Model = model;
            Year = year;
            RentalRate = rentalRate;
        }
    }
}
