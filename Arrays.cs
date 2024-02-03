using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Arrays1
    {
        public void Array()
        {
            //stores the same data type values 
            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 1;
            EvenNumbers[2] = 2;

            Console.WriteLine(EvenNumbers);
            Console.WriteLine(EvenNumbers[2]);

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] carss = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] carsss = { "Volvo", "BMW", "Ford", "Mazda" };
        }
    }
    public class Arrays
    {
        public static void RunProgram()
        {
            Arrays1 arrays1 = new Arrays1();
            arrays1.Array();
            Console.WriteLine();
        }
    }
}
