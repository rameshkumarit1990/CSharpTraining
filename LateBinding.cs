using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class LateBinding
    {
        public static void RunProgram()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("FirstConsoleApp.CustomerA");
            object customerAInstance = Activator.CreateInstance(customerType);

            MemberInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Hello";
            parameters[1] = "World";

            //string fullName = (string)getFullNameMethod.Invoke(customerAInstance, parameters);

            //Console.WriteLine("Fullname is {0}", fullName);

        }
    }

    public class CustomerA
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

    }
}
