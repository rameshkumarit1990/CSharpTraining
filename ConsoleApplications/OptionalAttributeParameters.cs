using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class OptionalAttributeParameters
    {
        public static void RunProgram()
        {
            AddNumbers(25, 45);
            AddNumbers(10, 12, 13, 14, 8, 9);
        }

        //We can use [Optional] or [OptionalAttribute]
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional]params object[] restOfNumbers)
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
