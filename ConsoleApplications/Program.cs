using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void ProgramMain()
        {
            Console.WriteLine("Program");
        }
        //{
        //    //Writing to the console..
        //    Console.WriteLine("My first C# ConsoleApp Practice");
        //    Console.WriteLine("My name is Pinky...whats your name..?");

        //    //Reading from the console..
        //    string UserName = Console.ReadLine();

        //    /*Two ways of Write to console.
        //        1.Concatination.
        //        2.Place holder*/
        //    Console.WriteLine("Hello " + UserName);
        //    Console.WriteLine("what is your Last name {0} ..??", UserName);

        //    string LastName = Console.ReadLine();
        //    Console.WriteLine("Ohh so you are {0} {1}", LastName, UserName);

        //    /* Built-in types in C#..
        //     * Boolean - only treue or false.
        //     * Integral types - sbyte,byte,short,ushort,int,uint,long,ulong,char.
        //     * Floating types - float and double
        //     * Decimal Type
        //     * String Type
        //     */

        //    bool a = true;
        //    int i = 2;
        //    Console.WriteLine("min={0}", float.MinValue);
        //    Console.WriteLine("max={0}", float.MaxValue);
        //    double d = 234.4874876553;
        //    int myNum = 5;
        //    double myDoubleNum = 5.99D;
        //    char myLetter = 'D';
        //    bool myBool = true;

        //    //const..
        //    const int num = 10;

        //    //escape sequence..
        //    string myText = "\"Hello\"";

        //    //Verbatim literal..//used to escape escape sequences for special charecters.
        //    string link = @"""E:\PINKY\REACT\practice tasks\dashboard.jpg""";

        //    /*Operators
        //    1.Assignment operator (=)
        //    2.Arithmetic operators (+, -, *, /, %)
        //    3.Comparison operators (==, !=, >, <, >=, <=)
        //    4.Logical operators (&&, ||, !)
        //    5.Bitwise operators (&, |, ^, ~, <<, >>)
        //    6.Increment and Decrement operators (++, --)
        //    7.Ternary - (condition)?(true block):(false block)

        //    8. null Coalescing operater - ??*/


        //    int? eggs = null;

        //    int boughtEggs = 12;

        //    boughtEggs = eggs ?? 0;

        //    Console.WriteLine("total eggs:{0}", boughtEggs);

        //    // Datatype conversion
        //    // Implicit , Explicit..

        //    float b = i;
        //    Console.WriteLine(b);
        //    double c = 34.6887676;
        //    int v = (int)c;
        //    Console.WriteLine(v);

        //    double n = 34345.6887676;
        //    int m = Convert.ToInt32(n);
        //    Console.WriteLine(m);

        //    //Parse method throws an exception if it cannot Parse the value.

        //    string input = "123";
        //    int number;

        //    if (int.TryParse(input, out number))// Try Parse returns a boolean value
        //    {
        //        Console.WriteLine("The string '{0}' was successfully parsed to the number {1}", input, number);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The string '{0}' could not be parsed to an integer", input);
        //    }

        //    //Arrays in C#...

        //    int[] numbers = new int[5];
        //    numbers = [1, 2, 3, 4, 5];

        //    int firstNumber = numbers[0];
        //    // Accessing the first element with indeex
        //    int secondNumber = numbers[1];
        //    // Accessing the second element

        //    Console.WriteLine(secondNumber);

        //    //iterating through an array..
        //    for (int j = 0; j < numbers.Length; j++)
        //    {
        //        Console.WriteLine(numbers[j]);
        //    }

        //    Console.WriteLine("enter a number");
        //    int enteredNum = int.Parse(Console.ReadLine());

        //    //if statement...

        //    if (enteredNum > 0)
        //    {
        //        Console.WriteLine("Entered Number is {0}", enteredNum);
        //        int result = num + enteredNum;
        //        Console.WriteLine(result);
        //    } else if (enteredNum < 0)
        //    {
        //        Console.WriteLine("number should be greater than 0");
        //    }
        //    else
        //    {
        //        Console.WriteLine("maybe number is 0");
        //    };

        //    // create the instance of the class to call the method in which it is present
        //    Program p = new Program();
        //    EvenNumbers();

        //    //to call a static method we dont create an instance of the class instead we call through the class name..
        //    Program.EvenNumbers1();

        }
        ////Methods...

        //public static void EvenNumbers()
        //{
        //    int start = 0;
        //    while(start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 2;
        //    }
        //}

        //public static void EvenNumbers1()
        //{
        //    int start = 0;
        //    while (start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start += 2;
        //    }
        //}

}
