using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class InnerException
    {
        public static void RunProgram()
        {
            try
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
                catch (Exception ex)
                {
                    string filePath = @"E:\PINKY\C#\log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Write(ex.StackTrace);
                        streamWriter.WriteLine();
                        streamWriter.Close();
                        Console.WriteLine("There is a problem please check log file. The file path is {0} ", filePath);
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present.", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception: {exception.Message}");
                Console.WriteLine($"Current Exception: {exception.GetType().Name}");
                Console.WriteLine($"Inner Exception: {exception.InnerException.GetType().Name}");
            }

        }
    }
}
