using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class OverrideToString
    {
        public static void RunProgram()
        {
            int Number = 10;
            Console.WriteLine(Number);

            StudentOne studentOne = new StudentOne();
            studentOne.FirstName = "Test";
            studentOne.LastName = "Data";

            Console.WriteLine(studentOne.ToString());
        }
    }

    public class StudentOne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " "+ this.LastName;
        }

    }
}
