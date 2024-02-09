using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_7OverflowException
    {
        public static void RunProgram()
        {
            Console.WriteLine(" C# program that creates a method that calculates " +
                "the factorial of a given number. Handle the OverflowException " +
                "that occurs if the result exceeds the Int32 maximum value.");
            try
            {
                Console.WriteLine("Input a positive number(integer)");
                int number = Convert.ToInt32(Console.ReadLine());
                int factorial = CalculateFactorial(number);
                Console.WriteLine("Factorial: " + factorial);
            }catch (OverflowException)
            {
                Console.WriteLine("Error: Factorial exceeds the maximum value of Int32.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Method to calculate the factorial of a number
        static int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                // Throw an ArgumentException for negative input numbers
                throw new ArgumentException("Number must be non-negative.");
            }
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                /*The checked keyword ensures that arithmetic overflow exceptions are thrown
                 * if the result of an arithmetic operation exceeds the range of the data type.
                 * In this case, it's ensuring that the factorial calculation does not exceed 
                 * the capacity of the int data type.*/
                checked
                {
                    factorial *= i;
                }
            }
            return factorial;
        }
    }
}
