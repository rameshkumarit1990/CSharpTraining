using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class ExceptionAbuseSolution
    {
        public static void RunProgram()
        {
            try
            {
                Console.WriteLine("Please Enter Numerator");
                int Numerator;
                int Denominator;
                bool IsNumeratorValid = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (IsNumeratorValid)
                {
                    Console.WriteLine("Please Enter Denominator");
                    bool IsDenominatorValid = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (IsDenominatorValid && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Division of {0} and {1} is {2} ", Numerator, Denominator, Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator should be greater than zero.");

                        }
                        else
                        {
                            Console.WriteLine("Denominator Should be a valid number between {0} and {1}", Int16.MinValue, Int16.MaxValue);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Numerator Should be a valid number between {0} and {1}", Int16.MinValue, Int16.MaxValue);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
