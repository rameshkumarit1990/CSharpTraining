using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class CO_3IntegerValue
    {
        public static void RunProgram()
        {
            try
            {
                Console.WriteLine("C# Sharp program to read the value of an integer m and" +
                    " display the value of n is 1 when m is larger than 0," +
                    " 0 when m is 0 and -1 when m is less than 0.");
                int m, n;
                Console.WriteLine("Enter an integer");
                m = Convert.ToInt32(Console.ReadLine());
                if (m != 0)
                {
                    if (m > 0)
                    {
                        n = 1;
                    }
                    else { n = -1; }
                }
                else { n = 0; }
                Console.WriteLine(" n = {0}",n);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
