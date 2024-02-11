using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class DefaultParameters
    {
        public static void RunProgram()
        {
            Test(1);
            Test(12, 15);

            //Pass 42 as argument for parameter c
            Test(4, c: 42);

        }

        public static void Test(int a, int b = 110, int c = 12)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + a);
            Console.WriteLine("c = " + a);
            Console.WriteLine("d = " + a);
        }
    }
}
