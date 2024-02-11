using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class SortList
    {
        public static void RunProgram()
        {
            List<int> Numbers = new List<int>() { 1, 8, 22, 34, 12, 9, 23, 3 };

            Console.WriteLine("-- Numbers before sorting ---");
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-- Numbers after sorting ---");
            Numbers.Sort();
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }

            List<string> StringData = new List<string>() { "Ed", "RD", "SE", "AE", "EE" };

            Console.WriteLine("-- Strings before sorting ---");
            foreach (string number in StringData)
            {
                Console.WriteLine(number);
            }
            StringData.Sort();
            Console.WriteLine("-- Strings after sorting ---");
            foreach (string number in StringData)
            {
                Console.WriteLine(number);
            }

            SortingCustomer SC1 = new SortingCustomer() { CustomerID = 101, CustomerName = "Raj" };
            SortingCustomer SC2 = new SortingCustomer() { CustomerID = 121, CustomerName = "Dan" };
            SortingCustomer SC3 = new SortingCustomer() { CustomerID = 11, CustomerName = "Sravani" };
            List<SortingCustomer> SC4 = new List<SortingCustomer>();
            SC4.Add(SC1);
            SC4.Add(SC2);
            SC4.Add(SC3);

            // SC4.Sort(); this line builds successfully but creates Run time error failed to compare.
            // To sort list of Objects follow below
            // below I have overiddden Compare to method in Sorting Customer class
            Console.WriteLine("-- Customers before sorting ---");
            foreach (SortingCustomer SC in SC4)
            {
                Console.WriteLine(SC.CustomerID);
            }
            SC4.Sort();
            Console.WriteLine("-- Customers after sorting based on ID ---");
            foreach (SortingCustomer SC in SC4)
            {
                Console.WriteLine(SC.CustomerID);
            }

            SortByName sortByName = new SortByName();

            Console.WriteLine("-- Customers Names before sorting ---");
            foreach (SortingCustomer SC in SC4)
            {
                Console.WriteLine(SC.CustomerName);
            }
            SC4.Sort(sortByName);
            Console.WriteLine("-- Customers Names after sorting ---");
            foreach (SortingCustomer SC in SC4)
            {
                Console.WriteLine(SC.CustomerName);
            }
        }
    }

    public class SortingCustomer : IComparable<SortingCustomer>
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        //public int CompareTo(SortingCustomer other)
        //{
        //    if (this.CustomerID > other.CustomerID)
        //    {
        //        return -1;
        //    }
        //    else if (this.CustomerID < other.CustomerID)
        //    {
        //        return 1;
        //    }
        //    else return 0;
        //}
        //The above logic can also be written as below in short form
        public int CompareTo(SortingCustomer other)
        {
            //You can sort with ID also like this.CustomerName.CompareTo(other.CustomerName)
            return this.CustomerID.CompareTo(other.CustomerID);
        }
    }

    public class SortByName : IComparer<SortingCustomer>
    {
        public int Compare(SortingCustomer x, SortingCustomer y)
        {
            //You can sort with ID also like this.CustomerID.CompareTo(other.CustomerID)
            return x.CustomerName.CompareTo(y.CustomerName);
        }
    }
}
 