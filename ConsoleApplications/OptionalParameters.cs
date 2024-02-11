using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class OptionalParameters
    {
        public static void RunProgram()
        {
            AddNumbers(25, 45);
            AddNumbers(10, 12, 13, 14, 8, 9);
            AddNumbers(21, 23, new object[] { 8, 4, 4, 7, 8 });

            //Method overloading
            AddNumbers(22, 24, null);
        }

        //Method overloading
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            AddNumbers(firstNumber, secondNumber, null);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum of Numbers is " + result);
        }
    }
}
