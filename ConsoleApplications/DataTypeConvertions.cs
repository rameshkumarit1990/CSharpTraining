using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    //convertions may through overflow exceptions if the data is out of its range
    //so we should make sure to convert to appropriate data types..
    public class Implicit
    {
        //implicit conversion is domne by the compiler 
        //there is no loss of information if the convertion is done.
        public static void Conversion()
        {
            int i = 500;
            float f = i;

            Console.WriteLine("{0} After implicit convertion of int to float {1}",i,f);
        }
    }

    public class Explicit
    {
        //this convertion is done by specifing the required type as the
        //compiler does not perform casting implicitly as there will be loss of data
        // in this from float to int we lost the decimal points and the result is
        //only the integer part..
        public static void Conversion()
        {
            float f = 123.45f;
           // int i = (int)f;
           //or
           int i = Convert.ToInt32(f);
            Console.WriteLine("{0} After explicit convertion from float to int {1}", f, i);
        }
    }

    public class Parsing
    {
        public static void Converstion()
        {
            string strNumber = "100";
            //parse to convert from string to int or any data type..
            int i = int.Parse(strNumber);
            Console.WriteLine("{0} string after parse: {1} int",strNumber,i);

            // this may throw exceptions if any unacceptable data is being parsed..
            //then we use tryParse() method to see if it can parse or throws an exception..

            string strNumber2 = "236JO";

            int j = 0;



            //Since it cannot parse the value it doesnot
            //assign any value to j and it remains unchanged
            // tryParse() returns a bool value if convertable true else false
            bool isConvertable = int.TryParse(strNumber2, out j);

            Console.WriteLine($"is Convertable: {isConvertable}");

            string condition = isConvertable ? "It is converted and the result is " : "Cannot convert the string,and the value is unchanged ";

            Console.WriteLine(condition +": "+ j);// O/P :- 0  

        }
    }
    public class DataTypeConvertions
    {
        public static void RunProgram()
        {
            Implicit.Conversion();
            Explicit.Conversion();
            Parsing.Converstion();
        }
    }
}
