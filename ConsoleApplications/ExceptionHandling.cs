using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstConsoleApp
{
    class ExceptionHandling
    {
        public static void RunProgram()
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"E:\PINKY\C#\sampl.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine(fe.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally { Console.WriteLine("Program Run Succesfulll..........!!!!!!!!!!!"); }
        }
    }
}
