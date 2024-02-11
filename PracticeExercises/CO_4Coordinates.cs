using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class CO_4Coordinates
    {
        public static void RunProgram()
        {
            try
            {
                int x, y;
                Console.Write("Input the value for X coordinate :");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the value for Y coordinate :");
                y = Convert.ToInt32(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"({x},{y}) lies in First Quadrent");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"({x},{y}) lies in Second Quadrent");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"({x},{y}) lies in Third Quadrent");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"({x},{y}) lies in Fourth Quadrent");
                }
                else if (x == 0 && y == 0)
                {
                    Console.WriteLine($"({x},{y}) lies at the Origin");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
