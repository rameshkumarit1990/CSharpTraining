using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstConsoleApp.PracticeExercises
{
    class CO_2LeapYear
    {
        public static void RunProgram()
        {
            Console.WriteLine("C# Sharp program to find out " +
                "whether a given year is a leap year or not.");
            try
            {
                Console.WriteLine("Enter the Year");
                int year;
                year = Convert.ToInt32(Console.ReadLine());
                if ((year % 400) == 0 && ((year % 4) == 0) && ((year % 4) == 0))
                {
                    Console.WriteLine("{0} is a leap Year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", year);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
