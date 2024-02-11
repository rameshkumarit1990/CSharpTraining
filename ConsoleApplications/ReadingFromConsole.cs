using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class ReadingFromConsole
    {
        public static void RunProgram()
        {
            Console.WriteLine("Write something to read from console..");
            //READING FROM CONSOLE..
            string Sentence = Console.ReadLine();
            //Writing to console
            Console.WriteLine("the entered sentence is : {0} ", Sentence);
        }
    }
}
