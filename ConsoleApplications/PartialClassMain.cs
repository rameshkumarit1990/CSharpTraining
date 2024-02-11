using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class PartialClassMain
    {
        public static void RunProgram() { 
            //The belopw line throws error as it is an abstract class.
            // PartialClassAbstract main = new PartialClassAbstract();

            PartialClassInheritance partialClassInheritance = new PartialClassInheritance();
            partialClassInheritance.GetDataName();
        }

        //The below code throws error as it is a sealed class.
        //public class SamplePartial : PartialClassSealed
        //{

        //}

    }
}
