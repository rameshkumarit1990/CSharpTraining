using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Usefull methods of list collection class
namespace FirstConsoleApp
{
    public class CollectionCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    class _80ListCollectionMethods
    {
        public static void RunProgram()
        {
            CollectionCustomer clC1 = new CollectionCustomer() { ID = 1, Name = "Hari", Salary = 5000 };
            CollectionCustomer clC4 = new CollectionCustomer() { ID = 4, Name = "Kari", Salary = 4000 };
            CollectionCustomer clC3 = new CollectionCustomer() { ID = 3, Name = "Biri", Salary = 6000 };
            CollectionCustomer clC2 = new CollectionCustomer() { ID = 2, Name = "Giri", Salary = 2000 };

            List<CollectionCustomer> clList = new List<CollectionCustomer>(10);
            clList.Add(clC1);
            clList.Add(clC4);
            clList.Add(clC3);
            clList.Add(clC2);

            //TrueForAll() checkes the list of objects under a condistion and returns a boolean
            Console.WriteLine("Are all salaries greater than 4000 ? -> "
                + clList.TrueForAll(x => x.Salary > 4000));

            /*
             * Returns a read only collection object of the customer
             * AsReadOnly() does not allow you to modify its elements but can be retrived
             */

            ReadOnlyCollection<CollectionCustomer> readOnlyclList =  clList.AsReadOnly();
            Console.WriteLine("count: {0}", readOnlyclList.Count);//can get count
            Console.WriteLine(readOnlyclList[0].Name);

            //Printing List capacity..
            Console.WriteLine("List Capacity: {0}", clList.Capacity);
            //Removes the extra capacity and sets it to the actuall number of elements
            //if the actuall capacity alocated is 90% full using TrimExcess does not work..
            clList.TrimExcess();

            Console.WriteLine("List Capacity: {0}", clList.Capacity);


        }
    }
}
