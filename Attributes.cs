using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Calculator
    {
        //[Obsolete("Use AddNumbers(List<int> Numbers) method")]
        //Or
        //[ObsoleteAttribute("Use AddNumbers(List<int> Numbers) method")]
        //or
        [ObsoleteAttribute("Use AddNumbers(List<int> Numbers) method",true)]

        public int AddNumbers(int x, int y)
        {
            return x + y;
        }
        public int AddNumbers(List<int> Numbers)
        {
            int sum = 0;
            foreach (int Number in Numbers)
            {
                sum += Number;
            }
            return sum;
        }
    }
    public class Attributes
    {
        public static void RunProgram()
        {
            Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.AddNumbers(20, 30)); //this line throws errors
            Console.WriteLine(calculator.AddNumbers([10, 20, 30, 40]));

        }
    }
}