using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    //public type Access Modifier  give access of that
    //perticular class anywhere in  the project.. 

    //classes can only be given access as public or internal class
    //internal can only be access in that perticular folder niot outside of tht folder
    //if not specified the access modifier the default access will be internal.
    internal class Internal1
    {
        public void PrintInternal()
        {
            Console.WriteLine("this is an internal class");
        }
    }
    public class AccessModifiers_4
    {
        public void PrintPublic()
        {
            Console.WriteLine("this is a public class");
        }
    }
    //default is private
    class Internal2
    {

    }
}
