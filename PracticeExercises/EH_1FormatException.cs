using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_1FormatException
    {
        public static void RunProgram()
        {
            Console.WriteLine("C# program that prompts the user to input two numbers and divides them." +
                " Handle an exception when the user enters non-numeric values.");
            try
            {
                //first number
                Console.WriteLine("Input First Number");
                String input1 = Console.ReadLine();
                double number1 = Convert.ToDouble(input1);
                //second number
                Console.WriteLine("Input Second Number");
                String input2 = Console.ReadLine();
                double number2 = Convert.ToDouble(input2);

                //handle 0 division error
                if (number2 != 0)
                {
                    double result = number1 / number2;
                    Console.WriteLine("Result = {0}", result);
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
                Console.WriteLine("Error: Non-numeric value entered.");
            }
            catch (Exception ex)
            {
                // Catch block for handling other types of exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
