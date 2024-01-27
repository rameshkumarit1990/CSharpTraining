using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class FirstClass
    {
        public FirstClass()
        {
            Console.WriteLine("firstClass constructor");
        }
        public static void PrintMethod()
        {
            Console.WriteLine("FirstClass Method 1");
        }

        public void PrintMethod2()
        {
            Console.WriteLine("FirstClass Method 2");
        }

        //This is how we need to use in main class
        //static void Main()
        //{
        //    Console.WriteLine("MainProgram");

        //    FirstClass firstClass = new FirstClass();
        //    FirstClass.PrintMethod();
        //    firstClass.PrintMethod2();

        //}
    }
}
