using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class EnumsWhy
    {
        //If a program uses set of integral numbers, consider replacing them with enums.
        //other wise the program becomes less READABLE AND MAINTAINABLE.
        //We need to replace these integral numbers with enums which makes the program better readable and maintainable
        public static void RunProgram()
        {
            EnumCustomer[] enumCustomers = new EnumCustomer[3];
            enumCustomers[0] = new EnumCustomer { Name = "Rahul", Gender = 1 };
            enumCustomers[1] = new EnumCustomer { Name = "Sandhya", Gender = 2 };
            enumCustomers[2] = new EnumCustomer { Name = "Tree", Gender = 0 };

            foreach (EnumCustomer enumCustomer in enumCustomers)
            {
                Console.WriteLine($"Name is {enumCustomer.Name} and gender is {GetGender(enumCustomer.Gender)}");
            }
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Other";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Data";
            }
        }
    }

    class EnumCustomer
    {
        //0 - unknown
        //1 - Male
        //2 - FeMale
        public string Name { get; set; }
        public int Gender { get; set; }
    }

}
