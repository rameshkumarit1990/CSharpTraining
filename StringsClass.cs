using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class CustomerDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class StringsClass
    {
        public static void RunProgram()
        {
            int Number = 15;
            Console.WriteLine(Number.ToString());
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.FirstName = "Lakkoju";
            customerDetails.LastName = "Sravani";
            Console.WriteLine(customerDetails.ToString());
        }
    }
}
