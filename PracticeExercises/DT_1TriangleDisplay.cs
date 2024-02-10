using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class DT_1TriangleDisplay
    {
        public static void RunProgram()
        {
            try
            {
                Console.Write("Input a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the desired width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                int height = width;

                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        Console.Write(num);
                    }
                    Console.WriteLine();
                    width--;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
