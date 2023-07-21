using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can create an object of our custom exception class
            CreditCardWithdrawException ex = new CreditCardWithdrawException("Insufficient funds", 1000, 500);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.Amount);
            Console.WriteLine(ex.Balance);

            // We can also throw an exception object
            throw ex;

            // We can also throw an exception object in a single line
            // throw new CreditCardWithdrawException("Insufficient funds", 1000, 500);

            // We can also throw an exception object in a single line, without creating a variable
            // throw new CreditCardWithdrawException("Insufficient funds", 1000, 500) { Amount = 1000, Balance = 500 };

        }
    }
}