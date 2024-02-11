using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class ExceptionHandlingAbuse
    {
        public static void RunProgram()
        {
            try
            {

                Console.WriteLine("Enter First Number");
                int FN = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int SN = Convert.ToInt16(Console.ReadLine());

                int result = FN / SN;
                Console.WriteLine("The Division of Two numbers is {0}", result);

            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please Enter Values Range Between {0} and {1}", Int16.MinValue, Int16.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator should be greater than 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
