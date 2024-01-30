using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    /// <summary>
    /// TruckRental is a derived class that inherits from RentalTransaction (base / parent class)
    /// </summary>
    internal class TruckRental : RentalTransaction
    {
        /// <summary>
        /// These properties are representing the truck rental information
        /// </summary>
        public string CustomerName { get; set; }
        public DateTime ActualReturnDate { get; set; }

        /// <summary>
        /// This is an object of the Truck class. It is reference to the rented truck
        /// </summary>
        private Truck RentedTruck;

        /// <summary>
        /// Parameterized constructor to initialize TruckRental attributes
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="rentalStartDate"></param>
        /// <param name="rentalEndDate"></param>
        /// <param name="rentedTruck"></param>
        /// <param name="customerName"></param>
        /// <param name="actualReturnDate"></param>
        public TruckRental(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate,
            Truck rentedTruck, string customerName, DateTime actualReturnDate)
            : base(transactionId, rentalStartDate, rentalEndDate)
        {
            RentedTruck = rentedTruck;
            CustomerName = customerName;
            ActualReturnDate = actualReturnDate;
        }

        /// <summary>
        /// This is an override method to calculate the rental cost of the truck.
        /// </summary>
        public override void CalculateRentalCost()
        {
            // Calculate the rental duration between two DateTime objects
            TimeSpan rentalDuration = RentalEndDate - RentalStartDate;

            // Get the total number of days in the duration by TotalDays and multiply with the rental rate
            double totalRentalCost = rentalDuration.TotalDays * RentedTruck.RentalRate;
            
            // Display the truck rental details
            Console.WriteLine(" - - The Truck Rental details are - - ");
            Console.WriteLine();
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Transaction ID: {TransactionId}");
            Console.WriteLine($"Vehicle: {RentedTruck.Make} {RentedTruck.Model}");
            Console.WriteLine($"Rental Duration: {RentalStartDate} to {RentalEndDate}");
            Console.WriteLine($"Actual Return Date: {ActualReturnDate}");
            Console.WriteLine($"Total Rental Cost: ${totalRentalCost}");
            Console.WriteLine();
        }
    }
}
