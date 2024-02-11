using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class EnumPartThree
    {
        public static void RunProgram()
        {
           /* // We need to typecast to respected value if you want to assign a value to enum;
            EnumGender Male = (EnumGender)3;
            int Fun = (int)EnumGender.Male; */


            int[] intValues = (int[])Enum.GetValues(typeof(CostEnum));
            foreach (int item in intValues)
            {
                Console.WriteLine("The Cost is {0} ", item);
            }

            short[] values = (short[])Enum.GetValues(typeof(EnumGender));
            foreach (short item in values)
            {
                Console.WriteLine("The Value is {0} ", item);
            }

            string[] Names = Enum.GetNames(typeof(EnumGender));
            foreach (string name in Names)
            {
                Console.WriteLine("The Value is {0} ", name);
            }
        }
    }

    public enum EnumGender : short
    {
        Other = 1,
        Male = 2,
        Female = 3,
    }

    public enum CostEnum
    {
        Tea,
        Cofee,
        Boost,
    }
}
