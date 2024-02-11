using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class StringAndStringBuilder
    {
        public static void RunProgram()
        {
            //String is present in system name space where as "StringBuilder is present in system.text"
            //String are Immutable and StringBuilder strings are mutable
            //Because of which we are having better performance with StringBuilder compared to system.string if there is heavy string manupulations.

            //mutable means if you change them in place those objects can be changed once created where as 
            //immutable means they cannot be changed if you have to change them you will end up creating another object.

            string Message = "Hello ";
            Message += "My ";
            Message += "Name ";
            Message += "Is ";
            Message += "Ramesh ";

            Console.WriteLine("For Each concating one memory is created.");
            Console.WriteLine("This is Immutable process and the message is {0}", Message);

            StringBuilder stringBuilder = new StringBuilder("Hello ");
            stringBuilder.Append("My ");
            stringBuilder.Append("Name ");
            stringBuilder.Append("Is ");
            stringBuilder.Append("Ramesh ");
            Console.WriteLine("This is Mutable process and the message is {0}", stringBuilder);

            string message1 = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                message1 += i.ToString() + " ";
            }
            Console.WriteLine("The Problem here is there are 9999 objects which are not used until garbage collector clears them.");
            Console.WriteLine(message1);

        }
    }
}
