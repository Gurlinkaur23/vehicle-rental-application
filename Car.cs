using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    /// <summary>
    /// Car is a derived class which inherits from Vehicle (base / parent class)
    /// </summary>
    internal class Car : Vehicle
    {
        /// <summary>
        /// This property is specific to cars
        /// </summary>
        public int NumberOfDoors { get; set; }

        /// <summary>
        ///Parameterized constructor to initialize the car attributes
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="rentalRate"></param>
        /// <param name="numberOfDoors"></param>
        public Car(int vehicleId, string make, string model, int year, double rentalRate, int numberOfDoors)
            : base(vehicleId, make, model, year, rentalRate)
        {
            NumberOfDoors = numberOfDoors;
        }

        /// <summary>
        /// This method displays the car related information to the console
        /// </summary>
        public void DisplayCarInfo()
        {
            Console.WriteLine(" - - Car Details - - ");
            Console.WriteLine();
            Console.WriteLine($"Id: {VehicleId}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Rate: {RentalRate}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine();
        }
    }
}
