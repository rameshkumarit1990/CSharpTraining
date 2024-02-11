using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{

    public class FirstChildHiding : Employee
    {
        public new void GetDetails()
        {
            Console.WriteLine("First Child is Hiding");
            base.FirstName = "Pullayya";
            base.GetDetails("30");
            //Console.WriteLine("Employee name :{0} {1} with id: {2} and salary is {3}", FirstName, LastName, Id, salary);
        }
    }


    class MethodHiding
    {
        public static void RunProgram()
        {
            FirstChildHiding firstChildHiding = new FirstChildHiding();

            ((Employee)firstChildHiding).GetDetails("2009");
            firstChildHiding.GetDetails();

            Employee employee = new FirstChildHiding();
            employee.GetDetails("1111");

            //FirstChildHiding firstChildHidinga = new Employee();


            Employee employee1 = new Employee();
            employee1.GetDetails("9889");

            float num = 22.33f;
            int number = (int)num;
            Console.WriteLine(number);
        }
    }
}
