using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_5ValueOutofRange
    {
        public static void RunProgram()
        {
            Console.WriteLine("C# program that reads a list of integers from the user." +
                " Handle the exception that occurs if the user " +
                "enters a value outside the range of Int32.");

            /*Int32 is an immutable value type that represents signed integers
             * with values that range from negative 2,147,483,648 (which is represented by the Int32.
             * MinValue constant)through positive 2,147,483,647 (which is represented by the Int32.*/

            List<int> numbers = new List<int>();
            try
            {
                Console.WriteLine("Input the list of integers");
                Console.WriteLine("enter exit to finish");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                        break;
                    int number = Convert.ToInt32(input);
                    numbers.Add(number);
                }
                Console.WriteLine("Numbers entered:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The value entered is outside the range of Int32.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
