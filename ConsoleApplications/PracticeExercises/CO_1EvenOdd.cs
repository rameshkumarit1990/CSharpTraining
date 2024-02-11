using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class CO_1EvenOdd
    {
        public static void RunProgram()
        {
            try
            {
                int number, reminder;
                Console.WriteLine("Enter a Number");
                number = Convert.ToInt32(Console.ReadLine());
                reminder = number % 2;
                if (reminder == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error : Enter a valid Number");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
