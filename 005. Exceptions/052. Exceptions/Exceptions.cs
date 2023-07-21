using System;
using System.IO;

namespace Exceptions
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            // try-catch-finally
            // try - block of code to try
            // catch - block of code to handle errors
            // finally - block of code to be executed regardless of the try-catch result
            try // try to execute the code in the block
            {
                int[] numbers = new int[5];
                numbers[6] = 10;
            } // if an error occurs, the catch block will be executed
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally // it will be executed regardless of the try-catch result
            {
                Console.WriteLine("Finally block executed.");
            }

            // Code after the try-catch-finally block will be executed
            Console.WriteLine("Code after try-catch-finally block.");

            Console.Write("Please enter a number: ");
            string? input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                Console.WriteLine("You entered: {0}", number);
            }
            // We can catch multiple exceptions
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            catch (Exception ex) // Exception is the base class for all exceptions
            {
                Console.WriteLine("Exception caught:");
                Console.WriteLine(ex.ToString());
                // Exception.ToString() returns the exception type, message, and stack trace
                // Exception.Message returns the message that describes the current exception
                // Exception.StackTrace returns a string representation of the immediate frames on the call stack
                // Exception.InnerException returns the exception that is the cause of the current exception
                // Exception.HelpLink returns or sets a link to the help file associated with this exception
                // Exception.Source returns or sets the name of the application or the object that causes the error
                // Exception.TargetSite returns the method that throws the current exception
                // Exception.Data returns the collection of key/value pairs that provide additional user-defined information about the exception
                // Exception.HResult returns or sets HRESULT, a coded numerical value that is assigned to a specific exception
            }
            finally
            {
                // The finally block is always executed, regardless of the try-catch result
                Console.WriteLine("Finally block executed.");
            }

            // Code after the try-catch-finally block will be executed
            FileStream? fs = null;
            try
            {
                fs = File.Open("test.txt", FileMode.Open); // throws FileNotFoundException
                //fs = new FileStream("test.txt", FileMode.Open);
            }
            // FileNotFoundException is a subclass of IOException
            // IOException is a subclass of Exception
            // We could use IOException instead of FileNotFoundException
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }
            // There is a catch without an exception type
            // It will catch all exceptions that are not caught by the previous catch blocks
            // It is not recommended to use it because it can hide errors
            catch
            {
                Console.WriteLine("Exception caught.");
            }
            finally
            {
                // We can use finally block, for example, to close a file
                // Or if file was opened but with an error, we can close it in the finally block
                // or to clear resources using Dispose() method
                if (fs != null)
                {
                    fs.Dispose(); // or fs.Close();
                }
            } 
            Console.WriteLine("Code after try-catch-finally block.");
        }
    }
}
