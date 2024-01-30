using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    /// <summary>
    /// CarRental is a derived class that inherits from RentalTransaction (base / parent class)
    /// </summary>
    internal class CarRental : RentalTransaction
    {
        /// <summary>
        /// These properties are representing the Car rental information
        /// </summary>
        public string CustomerName { get; set; }
        public DateTime ActualReturnDate { get; set; }

        /// <summary>
        /// This is an object of the Car class. It is reference to the rented Car
        /// </summary>
        private Car RentedCar;

        /// <summary>
        /// Parameterized constructor to initialize CarRental attributes
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="rentalStartDate"></param>
        /// <param name="rentalEndDate"></param>
        /// <param name="rentedCar"></param>
        /// <param name="customerName"></param>
        /// <param name="actualReturnDate"></param>
        public CarRental(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate,
              Car rentedCar, string customerName, DateTime actualReturnDate)
            : base(transactionId, rentalStartDate, rentalEndDate)
        {
            RentedCar = rentedCar;
            CustomerName = customerName;
            ActualReturnDate = actualReturnDate;
        }

        /// <summary>
        /// This is an override method to calculate the rental cost of the Car.
        /// </summary>
        public override void CalculateRentalCost()
        {
            // Calculate the rental duration between two DateTime objects
            TimeSpan rentalDuration = RentalEndDate - RentalStartDate;

            // Get the total number of days in the duration by TotalDays and multiply with the rental rate
            double totalRentalCost = rentalDuration.TotalDays * RentedCar.RentalRate;

            // Display the Car rental details
            Console.WriteLine(" - - The Car Rental details are - - ");
            Console.WriteLine();
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Transaction ID: {TransactionId}");
            Console.WriteLine($"Vehicle: {RentedCar.Make} {RentedCar.Model}");
            Console.WriteLine($"Rental Duration: {RentalStartDate} to {RentalEndDate}");
            Console.WriteLine($"Actual Return Date: {ActualReturnDate}");
            Console.WriteLine($"Total Rental Cost: ${totalRentalCost}");
            Console.WriteLine();
        }
    }
}
