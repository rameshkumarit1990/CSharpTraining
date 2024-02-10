using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public partial class PartialClassesTwo
    {
    }
    internal partial class PartialClassABC
    {
        //All parts spread across different files must have the same access modifiers.
    }
    public abstract partial class PartialClassAbstract
    {
        //If any of the parts are declared abstract, then the entire type is considered abstract
        //If you try to create an instance of that class it wil throw an error check in Partial class main.
    }

    public sealed partial class PartialClassSealed
    {
        //If any of the parts are declared sealed, then the entire type is considered sealed which cannot be inherited
    }

    public partial class PartialClassInheritance : PartialSample
    {
        //If any of the parts inherit a class, then the entire type inherits that class.
    }

    //public partial class PartialMultipleInheritance : PartialSample
    //{
    //    //C# doesnot support multiple class inheritance.
    //    //Different parts of the partial class, must not specify different base classes.
    //}

    public class PartialSample
    {
        public void GetDataName()
        {
            Console.WriteLine("Get Data Name");
        }
    }

    public class PartialCustomer
    {
        public void GetCustomerName()
        {
            Console.WriteLine("Get Data Name");
        }
    }

    public partial class PartialClassInterface : IPartialOne
    {
        //Different parts of the partial class can specify different base interfaces, and
        //the final type implements all of the interfaces listed by all of the partial declarations.
        public void DisplayName()
        {
            Console.WriteLine("Welcome Display Name");
        }
        public void PrintMessage()
        {
            Console.WriteLine("Welcome Print Message ");
        }
    }

    public interface IPartialOne
    {
        void DisplayName();
    }

    public interface IPartialTwo
    {
        void PrintMessage();
    }

}
