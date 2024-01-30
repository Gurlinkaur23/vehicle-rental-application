using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating car objects from base class Car
                Car car1 = new Car(1, "Honda", "Accord", 2022, 55, 4);
                Car car2 = new Car(2, "Ford", "Mustang", 2020, 75, 2);

                // Creating truck objects from base class Truck
                Truck truck1 = new Truck(5, "Dodge", "Ram", 2023, 85, 5500);
                Truck truck2 = new Truck(6, "GMC", "Sierra", 2020, 88, 6000);

                // Adding vehicles to the rental agency
                RentalAgency.AddVehicles(car1);
                RentalAgency.AddVehicles(car2);
                RentalAgency.AddVehicles(truck1);
                RentalAgency.AddVehicles(truck2);

                // Displaying information about the added cars and trucks
                car1.DisplayCarInfo();
                car2.DisplayCarInfo();
                truck1.DisplayTruckInfo();
                truck2.DisplayTruckInfo();

                // Processing car rentals
                CarRental carRental1 = new CarRental(10, DateTime.Now, DateTime.Now.AddDays(5), car1, "Mike Wheeler",
                    DateTime.Now.AddDays(6));
                RentalAgency.ProcessCarRental(carRental1);

                CarRental carRental2 = new CarRental(20, DateTime.Now, DateTime.Now.AddDays(2), car1, "Will Byers",
                    DateTime.Now.AddDays(3));
                RentalAgency.ProcessCarRental(carRental2);

                // Processing truck rentals
                TruckRental truckRental1 = new TruckRental(30, DateTime.Now, DateTime.Now.AddDays(3), truck1, "Dustin Henderson",
                    DateTime.Now.AddDays(4));
                RentalAgency.ProcessTruckRental(truckRental1);

                TruckRental truckRental2 = new TruckRental(40, DateTime.Now, DateTime.Now.AddDays(4), truck2, "Lucas Sinclair",
                    DateTime.Now.AddDays(5));
                RentalAgency.ProcessTruckRental(truckRental2);

                Console.WriteLine();

                // Displaying rental history of vehicles
                RentalAgency.DisplayRentalHistory();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

    }
}
