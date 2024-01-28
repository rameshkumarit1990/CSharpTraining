using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class MainProgram
    {
        public MainProgram()
        {
            Console.WriteLine("MainProgram Constructor");
        }

        static void Main()
        {
            Console.WriteLine("MainProgram");

            Strings.RunProgram();
        }
    }
}
