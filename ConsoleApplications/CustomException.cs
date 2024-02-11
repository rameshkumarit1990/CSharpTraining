using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class HandleMyException : Exception
    {
        public HandleMyException(string message) : base(message)
        {
        }

    }

    class CustomException
    {
        public static void RunProgram()
        {
            try
            {
            throw new HandleMyException("This is my exception message");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
