using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class ConvertToStringAndToString
    {
        public static void RunProgram()
        {
            ABC abc1 = new ABC();
            string s1 = Convert.ToString(abc1);
            Console.WriteLine("When abc1 is assigned Convert.ToString returns {0}", s1);

            ABC abc2 = null;
            string s2 = Convert.ToString(abc2);
            Console.WriteLine("When abc2 is null Convert.ToString returns {0}", s2);

            ABC abc3 = new ABC();
            string s3 = abc3.ToString();
            Console.WriteLine("When abc3 is assigned ToString returns {0}", s3);

            ABC abc4 = null;
            //Throws an null reference exception
            string s4 = abc4.ToString();
            Console.WriteLine("When abc4 is null ToString returns {0}", s4);

        }
    }

    class ABC
    {
        public string FirstName { get; set; }
    }
}
