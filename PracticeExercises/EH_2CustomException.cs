using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_2CustomException
    {
        public static void RunProgram()
        {
            Console.WriteLine("C# program to implement a method that takes " +
                "an integer as input and throws an exception if the number is negative." +
                " Handle the exception in the calling code.");

            try
            {
                Console.Write("Input an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());
                ValidatePositiveNumber(number);
                Console.WriteLine("Valid Number : {0}", number);
            }
            catch (NegativeNumberException ex)
            {
                // Catch block for handling NegativeNumberException
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        // Method to validate if the number is positive
        public static void ValidatePositiveNumber(int  number)
        {
            if(number < 0)
            {
                throw new NegativeNumberException("Negative number not allowed.");
            }
        }
    }

    // Custom exception class for handling negative number scenarios
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }
}
