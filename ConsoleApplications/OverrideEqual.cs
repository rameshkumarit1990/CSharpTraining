using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class OverrideEqual
    {

        public static void RunProgram()
        {
            CustomerEqualOne CE1 = new CustomerEqualOne();
            CE1.FirstName = "AD";
            CE1.LastName = "BD";

            CustomerEqualOne CE2 = CE1;

            Console.WriteLine("By using base EQUALS Method");
            Console.WriteLine(CE1 == CE2);
            Console.WriteLine(CE1.Equals(CE2));
            Console.WriteLine("-----------");

            Console.WriteLine("By overiding base EQUALS Method");


            CustomerEqual C1 = new CustomerEqual();
            C1.FirstName = "A";
            C1.LastName = "B";


            CustomerEqual C2 = new CustomerEqual();
            C2.FirstName = "A";
            C2.LastName = "B";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }

    public class CustomerEqualOne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class CustomerEqual
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (!(obj is CustomerEqual))
            {
                return false;
            }

            return this.FirstName == ((CustomerEqual)obj).FirstName && this.LastName == ((CustomerEqual)obj).LastName;
        }

    }
}
