using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class InternalClass1 : InternalClass2
    {
        //internal fields are accessable only in the containing assembly
        //cant be accessed in another assemly
        internal int Num = 123;
        //to access the internal protected Field created in
        //AccessModifiers_2 class as internalClass2 field use
        public void Printing()
        {
            InternalClass2 internalClass2 = new InternalClass2();
            Console.WriteLine(internalClass2.RollNo);
            Console.WriteLine(base.RollNo);
        }

    }
    class AccessModifiers_3
    {
        public static void RunProgram()
        {
            InternalClass1 internalClass1 = new InternalClass1();
            Console.WriteLine(internalClass1.Num);//can be accessable
            internalClass1.Printing();
        }
    }
}
