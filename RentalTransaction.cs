using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    /// <summary>
    /// This is an abstract class that is related to the vehicle rental transaction
    /// </summary>
    internal abstract class RentalTransaction
    {
        /// <summary>
        /// Properties representing the rental transaction information
        /// </summary>
        public int TransactionId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }

        /// <summary>
        /// Parameterized constructor to initialize rental transaction attributes
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="rentalStartDate"></param>
        /// <param name="rentalEndDate"></param>
        protected RentalTransaction(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate)
        {
            TransactionId = transactionId;
            RentalStartDate = rentalStartDate;
            RentalEndDate = rentalEndDate;
        }

        /// <summary>
        /// This is an abstract method to calculate the rental cost of the vehicles. The implementation will be
        /// written in the derived classes
        /// </summary>
        public abstract void CalculateRentalCost();
    }
}
