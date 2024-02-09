using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_6DateTimeObject
    {
        public static void RunProgram()
        {
            Console.WriteLine(@"C# program that creates a method that reads a date from the user " +
                "in the format \"dd/mm/yyyy\" and converts it to a DateTime object." +
                " Handle an exception if the input format is invalid.");
            try
            {
                // Prompt the user to input a date in a specific format (dd/mm/yyyy)
                Console.Write("Input a date (format-> dd/mm/yyyy): ");
                string input = Console.ReadLine();

                // Convert the user-input string to a DateTime object using the ConvertToDate method
                DateTime date = ConvertToDate(input);
                Console.WriteLine("Date: " + date.ToShortDateString());
            }
            catch (FormatException)
            {
                // Catch block for handling FormatException (invalid date format)
                Console.WriteLine("Error: Invalid date format. Please input a valid date in the format dd/mm/yyyy.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }
        // Method to convert a string to a DateTime object based on a specific format
        static DateTime ConvertToDate(string input)
        {
            // Define the date format expected from the user input
            string[] format = { "dd/MM/yyyy" };
            // Parse the input string to a DateTime object using the specified format
            return DateTime.ParseExact(input, format, null, System.Globalization.DateTimeStyles.None);
        }
    }
}
