using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class OverLoading
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static void Add(int a, int b,out int sum)
        {
           sum = a + b;
        }


        public static void Add(string a)
        {
          Console.WriteLine(a);
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static void RunProgram()
        {
            int value = 0;
            Add(1, 5, out value);
            Console.WriteLine("sum of out method is {0}", value);

            Console.WriteLine(Add(1, 2));
            Console.WriteLine("sum is {0}",Add(5,5));
            Console.WriteLine(Add(2.5f, 3.55f));
            Add("chsngeColor");
        }

    }
}
