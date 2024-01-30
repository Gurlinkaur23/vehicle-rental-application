using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    /// <summary>
    /// This is a static class which represents the Vehicle Rental Agency
    /// </summary>
    internal static class RentalAgency
    {
        // Creating different lists for storing the objects of different classes
        static List<Vehicle> VehiclesList = new List<Vehicle>();
        static List<CarRental> CarRentalList = new List<CarRental>();
        static List<TruckRental> TruckRentalList = new List<TruckRental>();

        /// <summary>
        /// This mehtod adds vehicles to the inventory
        /// </summary>
        /// <param name="vehicle"></param>
        public static void AddVehicles(Vehicle vehicle)
        {
            VehiclesList.Add(vehicle);
        }

        /// <summary>
        /// This method processes the car rentals
        /// </summary>
        /// <param name="carRental"></param>
        public static void ProcessCarRental(CarRental carRental)
        {
            CarRentalList.Add(carRental);
            Console.WriteLine("Car Rental has been processed successfully");
        }

        /// <summary>
        /// This method processes the truck rentals
        /// </summary>
        /// <param name="truckRental"></param>
        public static void ProcessTruckRental(TruckRental truckRental)
        {
            TruckRentalList.Add(truckRental);
            Console.WriteLine("Truck Rental has been processed successfully");

        }

        /// <summary>
        /// This method displays the rental history of the vehicles
        /// </summary>
        public static void DisplayRentalHistory()
        {
            Console.WriteLine("- - - - Rental History - - - - ");
            Console.WriteLine();
            
            // Displaying the car rental history
            foreach (CarRental carRental in CarRentalList)
            {
                carRental.CalculateRentalCost();
            }
            Console.WriteLine();

            // Displaying the truck rental history
            foreach (TruckRental truckRental in TruckRentalList)
            {
                truckRental.CalculateRentalCost();
            }
            Console.WriteLine();

        }

    }
}
