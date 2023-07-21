using System;

namespace Exceptions
{
    // Custom exception class - inherits from Exception
    // We can also inherit from other exceptions, like ApplicationException
    // When we throw an exception, we can throw an object of this class
    // When we name the class, we should end it with the word "Exception" - this is a convention
    public class CreditCardWithdrawException : Exception
    {
        // We can add custom properties to our exception class
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }

        // We can also add custom constructors
        public CreditCardWithdrawException(string message, decimal amount, decimal balance)
            : base(message)
        {
            Amount = amount;
            Balance = balance;
        }
    }
}