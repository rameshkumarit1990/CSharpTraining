using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_3FileNotFound
    {
        public static void RunProgram()
        {
            Console.WriteLine("C# program that reads a file path from the user and tries to open the file." +
                " Handle exceptions if the file does not exist");
            Console.Write("Input the file path: ");
            //give the file name here
            string filePath = @"E:\PINKY\C#\sample.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("File opened successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                // Catch block for handling FileNotFoundException
                Console.WriteLine("Error: File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }

    }

}

