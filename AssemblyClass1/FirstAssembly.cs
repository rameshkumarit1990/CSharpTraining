namespace AssemblyClass1
{
    public class FirstAssembly
    {
        private static int Numerator = 29;

        private static void PrivatePrint()
        {
            Console.WriteLine("Assembly Class private Print");
        }
        public static void PublicPrint()
        {
            Console.WriteLine("Assembly Class Public Print");
        }

        protected static void ProtectedPrint()
        {
            Console.WriteLine("Assembly Class Protected Print");
        }

        internal static void InternalPrint()
        {
            Console.WriteLine("Assembly Class Internal Print");
        }

        protected internal static void ProtectedInternalPrint()
        {
            Console.WriteLine("Assembly Class Protected Internal Print");
        }

    }

    public class FirstAssembly1
    {
        public static void Print23()
        {
            // cannot access as it is private
            //FirstAssembly.PrivatePrint(); 

            FirstAssembly.PublicPrint();

            // cannot access as it is protected
            //FirstAssembly.ProtectedPrint(); 

            FirstAssembly.InternalPrint();

            FirstAssembly.ProtectedInternalPrint();


        }
    }
}
