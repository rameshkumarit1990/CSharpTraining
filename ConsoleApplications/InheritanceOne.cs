using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Employee
    {
        public string Id;
        public string FirstName;
        public string LastName;

        public Employee()
        {
            Console.WriteLine("Parent Constructor");
        }
        public Employee(string name)
        {
            Console.WriteLine("Parent Constructor {0}",name);
            this.GetDetails(name);
        }
        public void GetDetails(string salary)
        {
            Console.WriteLine("Employee name :{0} {1} with id: {2} and salary is {3}", FirstName, LastName, Id, salary);
        }

    }

    public class FullTimeEmployee : Employee
    {
        public string YearlySalary;

        public FullTimeEmployee(string yearlySalary)
        {
            this.YearlySalary = yearlySalary;
            Console.WriteLine("Full Time Employee one parameter Constructor");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public string? HourlyPay = null;

        public PartTimeEmployee():base("sravani") 
        {
            Console.WriteLine("Part time constructor");
        }

    }

    class InheritanceOne
    {
        public static void EmployeeDetails()
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("200000");
            fullTimeEmployee.FirstName = "Subbayya";
            fullTimeEmployee.LastName = "Raj";
            fullTimeEmployee.Id = "1001";
            fullTimeEmployee.GetDetails("200000");

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Ram";
            partTimeEmployee.LastName = "Raj";
            partTimeEmployee.Id = "1002";
            partTimeEmployee.HourlyPay = "20";
            partTimeEmployee.GetDetails("20");
        }

    }
}
