using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class EnumSolution
    {
        public static void RunProgram()
        {
            EnumSolutionCustomer[] customers = new EnumSolutionCustomer[3];
            customers[0] = new EnumSolutionCustomer { Name = "Rahul", Gender = Gender.Male };
            customers[1] = new EnumSolutionCustomer { Name = "Sandhya", Gender = Gender.Female };
            customers[2] = new EnumSolutionCustomer { Name = "Tree", Gender = Gender.Other };

            foreach (EnumSolutionCustomer customer in customers)
            {
                Console.WriteLine($"Name is {customer.Name} and gender is {GetGender(customer.Gender)}");
            }
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Other:
                    return "Other";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data";
            }
        }
    }

    public enum Gender
    {
        Other,
        Male,
        Female
    }

    class EnumSolutionCustomer
    {
        //0 - unknown
        //1 - Male
        //2 - FeMale
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
