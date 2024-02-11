using AssemblyClass1;

namespace AssemblyClass2
{
    public class SecondAssembly : FirstAssembly
    {
        public static void Print2()
        {
            Console.WriteLine("Assembly Class 2");
            FirstAssembly.PublicPrint();

            // accessible as it is protected and derived class
            FirstAssembly.ProtectedPrint();

            // Not accessible as it is internal even if is derived
            //FirstAssembly.InternalPrint();

            // accessible as it is protected and derived class
            FirstAssembly.ProtectedInternalPrint();

        }

    }

    public class SecondAssemblyOne
    {
        public static void Print2()
        {
            Console.WriteLine("Assembly Class 2");
            FirstAssembly.PublicPrint();

            // Not accessible as it is protected
            //FirstAssembly.protectedPrint(); 

            // Not accessible as it is internal.
            //FirstAssembly.InternalPrint();

            //Not accessible as it is protected
            //FirstAssembly.ProtectedInternalPrint();

        }

    }
}

