using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    //converting value type into object type is called Boxing..
    //changing int to object data type to take all types of data(int,string..) 
    //boxing happens as it coverts i/p type
    //this object type accepts any type and performs the comparision..
    //but not between two values of same type
    //to solve this we make use of generics..
    public class EqualClass//<T>// we can even make class generic
    {
        //using generics here makes the method independent of data type..
        //public static bool AreEqual(object value1, object value2) using generics to this
        public static bool AreEqual<T>(T value1, T value2)
        {
            //return value1 == value2;
            return value1.Equals(value2);
        }
    }
    public class Generics
    {
        public static void RunProgram()
        {
            bool Equal = EqualClass.AreEqual<String>("g", "b");
            //specifing what type should be taken as input..if voilated throws an error
            //,both should be strings
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

    }
}
