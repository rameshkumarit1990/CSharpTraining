using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleApp
{
    class Strings
    {
        String Name = "Kill Bill Pandey";
        String RealName = "Padhmanabasimha";
        string LastName = "John Doe";


        public static void RunProgram()
        {
            Strings strings = new Strings();
            Console.WriteLine("Length of string {0}", strings.Name.Length);
            Console.WriteLine(strings.Name.ToUpper());
            Console.WriteLine(strings.Name.ToLower());
            Console.WriteLine(strings.Name + strings.RealName);
            Console.WriteLine(strings.RealName.Concat(strings.Name));
            Console.WriteLine($"Interpolation property same like template string : {strings.Name} hrhhrrh {strings.RealName}");
            Console.WriteLine("---Access through index----");
            Console.WriteLine("output will be 'h' as it is in 3rd index of string..{0}",strings.RealName[3]);
            Console.WriteLine("Index of B in Name: {0}", strings.Name.IndexOf("B"));
            int charPos = strings.LastName.IndexOf("D");
            Console.WriteLine( strings.LastName.Substring(charPos));



        }
    }
}
