using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class GenericListClass
    {
        public static void RunProgram()
        {

            Merchant M1 = new Merchant() { ID = 1, Name = "A", Type = "Retail", };
            Merchant M2 = new Merchant() { ID = 2, Name = "B", Type = "Retail", };
            Merchant M3 = new Merchant() { ID = 3, Name = "C", Type = "Retail", };
            Merchant M4 = new Merchant() { ID = 4, Name = "D", Type = "Wholesale", };
            Merchant M5 = new Merchant() { ID = 5, Name = "D", Type = "Wholesale", };

            List<Merchant> RetailMerchant = new List<Merchant>();
            RetailMerchant.Add(M1);
            RetailMerchant.Add(M2);
            RetailMerchant.Add(M3);

            List<Merchant> WholesaleMerchant = new List<Merchant>();
            WholesaleMerchant.Add(M4);
            WholesaleMerchant.Add(M5);

            //AddRange combines lists
            RetailMerchant.AddRange(WholesaleMerchant);

            foreach (Merchant item in RetailMerchant)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

            //GetRange receives objects within that range

            List<Merchant> RM = RetailMerchant.GetRange(0, 3);

            Console.WriteLine("--- Get Range ---");
            Console.WriteLine("--- Retail Merchants ---");
            foreach (Merchant item in RM)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

            List<Merchant> WM = RetailMerchant.GetRange(3, 2);

            Console.WriteLine("--- Wholesale Merchants ---");
            foreach (Merchant item in WM)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

            //InsertRange inserts objects to specified locations range
            RetailMerchant.InsertRange(0, WholesaleMerchant);
            Console.WriteLine("--- Insert Range ---");
            foreach (Merchant item in RetailMerchant)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

            //RemoveAt
            RetailMerchant.RemoveAt(3);
            Console.WriteLine("--- Remove At ---");
            foreach (Merchant item in RetailMerchant)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

            //RemoveAll
            RetailMerchant.RemoveAll(x => x.Type == "Wholesale");
            Console.WriteLine("--- Remove All ---");
            foreach (Merchant item in RetailMerchant)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

            //RemoveRange
            RetailMerchant.RemoveRange(0, 1);
            Console.WriteLine("--- Remove Range ---");
            foreach (Merchant item in RetailMerchant)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Type ={2}", item.ID, item.Name, item.Type);
            }

        }
    }

    public class Merchant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
