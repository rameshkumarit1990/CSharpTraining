using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public partial class PartialClassesTwo
    {
        //All parts spread across different files must use partial keyword.

        public static void PrintAdd()
        {
            //Any members that are declared in a partial defination are available to all of the other parts of the partial class.
        }

    }
    internal partial class PartialClassABC
    {
        //All parts spread across different files must have the same access modifiers.
    }

    public partial class PartialClassAbstract
    {
    //If any of the parts are declared abstract, then the entire type is considered abstract
    }

    public partial class PartialClassInheritance
    {
        //If any of the parts inherit a class, then the entire type inherits that class.
    }

    //public partial class PartialMultipleInheritance : PartialCustomer
    //{
    //    //C# doesnot support multiple class inheritance.
    //    //Different parts of the partial class, must not specify different base classes.
    //}

    public partial class PartialClassInterface : IPartialTwo
    {
        //Different parts of the partial class can specify different base interfaces, and
        //the final type implements all of the interfaces listed by all of the partial declarations.

    }



}
