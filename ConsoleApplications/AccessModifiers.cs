using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class ClassOne
    {
        int Param1;
        public int? Param2;
        public static int? Param3;

        public ClassOne() { }
        public ClassOne(int a) { 
            this.Param1 = a;
        }

        public void DisplayValue()
        {
            Console.WriteLine(Param1);
            Console.WriteLine(Param2);
            Console.WriteLine(Param3);
        }

        public static int PintOutValue()
        {
            ClassOne classOne = new ClassOne(12);

            Console.WriteLine(classOne.Param1);
            Console.WriteLine(classOne.Param2);
            Console.WriteLine(Param3);
            ClassOne.PintValue();
            return 0;
        }
        public static void PintValue()
        {
            ClassOne classOne = new ClassOne(66);
            Console.WriteLine(classOne.Param1);
            Console.WriteLine(classOne.Param2);
            Console.WriteLine(Param3);
            classOne.DisplayValue();
        }
    }

    class AccessModifiers
    {
        public static void RunProgram()
        {
            ClassOne.PintOutValue();
            ClassOne classOne2 = new ClassOne();
            classOne2.DisplayValue();
        }

    }
}
