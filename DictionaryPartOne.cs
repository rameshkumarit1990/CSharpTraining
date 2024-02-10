using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class DictionaryPartOne
    {
        public static void RunProgram()
        {
            DictionaryCustomer customer1 = new DictionaryCustomer();
            customer1.ID = 100;
            customer1.Name = "Test";
            customer1.Salary = 1200;

            DictionaryCustomer customer2 = new DictionaryCustomer() { ID = 101, Salary = 2000, Name = "Jimmy" };
            DictionaryCustomer customer3 = new DictionaryCustomer()
            {
                ID = 121,
                Name = "Tommy",
                Salary = 1500
            };

            //Dictionay is async collection of key value pairs
            Dictionary<int, DictionaryCustomer> dictionayCustomers = new Dictionary<int, DictionaryCustomer>();
            dictionayCustomers.Add(customer1.ID, customer1);
            dictionayCustomers.Add(customer2.ID, customer2);
            dictionayCustomers.Add(customer3.ID, customer3);

            DictionaryCustomer customer100 = dictionayCustomers[100];

            Console.WriteLine("ID = {0}, Name ={1}, Salary ={2}.", customer100.ID, customer100.Name, customer100.Salary);

            //Using for loop to print all values also

            foreach (KeyValuePair<int, DictionaryCustomer> DictionaryCustomerKeyValuePair in dictionayCustomers)
            {
                Console.WriteLine("Key ={0}", DictionaryCustomerKeyValuePair.Key);
                DictionaryCustomer customer = DictionaryCustomerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name ={1}, Salary ={2}.", customer.ID, customer.Name, customer.Salary);
                Console.WriteLine("--------------------------------");
            }

            //EventArgs this for loop works
            //I cannot tell what is the type of the key and what is type of value if we use var keyword.
            foreach (var DictionaryCustomerKeyValuePair in dictionayCustomers)
            {
                Console.WriteLine("Key ={0}", DictionaryCustomerKeyValuePair.Key);
                DictionaryCustomer customer = DictionaryCustomerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name ={1}, Salary ={2}.", customer.ID, customer.Name, customer.Salary);
                Console.WriteLine("--------------------------------");
            }
            /* Possible to retreive only the keys or only the values */
            foreach (int key in dictionayCustomers.Keys)
            {
                Console.WriteLine("Key ={0}", key);
            }
            foreach (DictionaryCustomer customer in dictionayCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name ={1}, Salary ={2}.", customer.ID, customer.Name, customer.Salary);
            }
            /*Notes
             * 
             * If we try to add an duplicate record it builds successfully but it will throw run time exception "Argument Exception"
             * keys within dictionary are should be unique
             * dictionayCustomers.Add(customer1.ID, customer1);
             * 
             * If we try to fetch an key which is not existing it builds successfully but it will throw run time exception "Key Not Found Exception"
             * Similarly we cannot get a record which is not existing
             * 
             */
            if (!dictionayCustomers.ContainsKey(customer1.ID))
            {
                dictionayCustomers.Add(customer1.ID, customer1);
            }
            if (dictionayCustomers.ContainsKey(customer1.ID))
            {
                DictionaryCustomer C1 = dictionayCustomers[customer1.ID];
            }

        }

        public class DictionaryCustomer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

    }
}
