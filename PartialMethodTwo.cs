using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public partial class PartialMethodClass
    {
        //Partial methods are private by default
        //We cannot add Private keyword also
        //it also cannot have vitual private public keywords..
        //Partial methods are void they cannot have any other return type

        //private partial void GetMe(); this throws compile time error as it is using private keyword

        partial void GetMyMessage(); 
        partial void SamplePartialMethod()
        {
            Console.WriteLine("Iam here");
            //We can implement this in PartialMethodOne class also
            // It can have both declaration and implementation
        }
        partial void GetMyMessage()
        {
            Console.WriteLine("implemented here...");
        }

    }
}
