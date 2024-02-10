using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.PracticeExercises
{
    class EH_4EmptyArray
    {
        public static void RunProgram()
        {
            Console.WriteLine("C# program that implements a method that takes " +
                "an array of integers as input and calculates the average value." +
                " Handle the exception if the array is empty.");

            try
            {
                Console.WriteLine("Input the size of the array");
                int count = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[count];
                Console.WriteLine("Enter array Elements");
                for (int i = 0; i < count; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                double average = CalculateAverage(numbers);
                Console.WriteLine("Average: " + average);
            }
            catch (EmptyArrayException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please input integers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Method to calculate the average of an array of integers
        static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                // Throw EmptyArrayException if the array is empty
                throw new EmptyArrayException("Array is empty. Cannot calculate average.");
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (double)sum / numbers.Length;
        }
    }

    // Custom exception class for EmptyArrayException
    class EmptyArrayException : Exception
    {
        public EmptyArrayException(string message) : base(message) { }
    }
}

