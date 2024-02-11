using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    /*Notes
     * List class can be used to create any type example List<CustomerClass> 
     * List can grow automatically in size unlike Arrays
     * List can add only its defined type. or any object that has inherited from the defined type class.
     * We can insert an object at specified location
     * We can get index of any object in list of collection which returns first index of the matching object
     * Contains method in list
     */
    public class ListCollectionPartOne
    {
        public static void RunProgram()
        {
            ListCustomer customer1 = new ListCustomer();
            customer1.ID = 100;
            customer1.Name = "Test";
            customer1.Salary = 1200;

            ListCustomer customer2 = new ListCustomer() { ID = 101, Salary = 2000, Name = "Jimmy" };
            ListCustomer customer3 = new ListCustomer()
            {
                ID = 121,
                Name = "Tommy",
                Salary = 1500
            };

            ListCustomer[] listCustomer = new ListCustomer[2];
            listCustomer[0] = customer1;
            listCustomer[1] = customer2;

            // This gets build successfully but in run time throws an index out of range exception as array dont grow in size.
            //listCustomer[2] = customer3;

            List<ListCustomer> customers = new List<ListCustomer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            //We can insert an object at specified location
            customers.Insert(1, customer3);

            ListCustomer C1 = customers[0];

            Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", C1.ID, C1.Name, C1.Salary);

            //We can iterate using foreach loop
            foreach (ListCustomer cust in customers)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", cust.ID, cust.Name, cust.Salary);
            }

            for (int i = 0; i < customers.Count; i++)
            {
                //If we use i <= customers.Count it will throw exception as index out of range
                //Instead of this for loop you can use foreach loop or keep the condition as i < customers.Count;
                ListCustomer cust = customers[i];
                Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", cust.ID, cust.Name, cust.Salary);
            }

            //List can add only its defined type. or any object that has inherited from the defined type class.
            //SavingsClass sc = new SavingsClass();
            //customers.Add(sc);

            //We can get index of any object in list of collection which returns first index of the matching object
            Console.WriteLine("Index of customer3 position {0}", customers.IndexOf(customer3));
            //Search can be specified from which position you want to search
            Console.WriteLine("Index of customer3 position {0}", customers.IndexOf(customer3, 1));
            //Search can be specified from which position you want to search and how many position you want to look into.
            Console.WriteLine("Index of customer3 position {0}", customers.IndexOf(customer3, 1, 3));
            //If you try to search which has no index stored value then it trows error
            //Suppose if in customers there are only 4 objects and when we try to load at record of position 5 it throws error.
            //Like below
            //Console.WriteLine("Index of customer3 position {0}", customers.IndexOf(customer3, 1, 5));


            //Contains method usage
            if (customers.Contains(customer3))
            {
                Console.WriteLine("Customer3 object exists.");
            }
            else
            {
                Console.WriteLine("Customer3 object does not exists.");
            }

            //Exists method usage
            if (customers.Exists(cust => cust.Name.StartsWith("t")))
            {
                Console.WriteLine("There is a customer whose name starts with T.");
            }
            else
            {
                Console.WriteLine("There is no customer whose name starts with T.");
            }
            //Diff b/n Contains and Exists is with Exists you can define a condition but in Contains you cannot use condition

            //Find method usage it return first occurance
            ListCustomer listCust = customers.Find(item => item.Salary > 3000);
            Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", listCust.ID, listCust.Name, listCust.Salary);

            //FindLast method usage it return last occurance
            ListCustomer LastCust = customers.Find(item => item.Salary > 3000);
            Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", LastCust.ID, LastCust.Name, LastCust.Salary);

            //FindAll method usage it return all occurance it return array of list
            List<ListCustomer> AllCust = customers.FindAll(item => item.Salary > 3000);

            foreach (ListCustomer customer in AllCust)
            {
                Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", customer.ID, customer.Name, customer.Salary);
            }

            //Findindex Method usage it returns index of availbale matching element.
            //It has  overload methods like indexof method
            int index = customers.FindIndex(item => item.Salary > 3000);
            Console.WriteLine("The index is {0}", index);

            int lastIndex = customers.FindLastIndex(item => item.Salary > 3000);
            Console.WriteLine("The Last index is {0}", lastIndex);

            //Convert an array to List use ToList() Method

            ListCustomer[] CustomerArray = new ListCustomer[2];
            CustomerArray[0] = customer1;
            CustomerArray[1] = customer2;

            List<ListCustomer> ArrayTolistCust = CustomerArray.ToList();


            //Convert an List to Array use ToArray() Method

            List<ListCustomer> customerList = new List<ListCustomer>(2);
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);

            ListCustomer[] listToArray = customerList.ToArray();

            //Convert an List to Dictionary use ToArray() Method

            Dictionary<int, ListCustomer> dictionary = customerList.ToDictionary(x => x.ID);

            foreach (KeyValuePair<int, ListCustomer> kvp in dictionary)
            {
                Console.WriteLine("Key is {0}", kvp.Key);
                ListCustomer customer = kvp.Value;
                Console.WriteLine("ID = {0}, Name= {1}, Salary ={2}", customer.ID, customer.Name, customer.Salary);
            }
        }

    }

    public class ListCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class SavingsClass : ListCustomer
    {

    }
}
