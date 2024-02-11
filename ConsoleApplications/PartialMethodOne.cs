using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public partial class PartialMethodClass
    {
        partial void SamplePartialMethod();

        public void PrintMethod()
        {
            Console.WriteLine("Sample Print Method");
            SamplePartialMethod();
            //This line will be ignored until it has some implementation.
            //Now we can implement it in another partial class added code in PartialMethodTwo class
        }
    }
}
