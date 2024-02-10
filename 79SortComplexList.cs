using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using Comparison delegate with List<T>
/*
 STEPS:
1.One of the overloads of the sort Method in List Class expects
  Comparison delegate to be passed as an argument.
       -> public void Sort(Comparision<T> comparison);
2.Create a function whose signature matches with the System.Comparison delegate.
  Contains the logic to Compare two Objects (Line 67).
3.Create an instance of System.Comparison delegate,and then pass the
    name of the function created for sorting.
    So,at this point "Comparision" delegate is pointing to our function
    that Contains logic to compare 2 ComplecCustomer Objects.
4.Now pass the delegate instance as an argument,to sort() function.
          ->  complexCostomerlist.Sort(CustomerComparer);
    
 */
namespace FirstConsoleApp
{
    //One of the overloads of the sort Method in List Class expects
    //Comparison delegate to be passed as an argument
    public class ComplexCustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    class _79SortComplexList
    {
        public static void RunProgram()
        {
            ComplexCustomer CC1 = new ComplexCustomer() { ID = 101, Name = "Hari", Salary = 30000 };
            ComplexCustomer CC2 = new ComplexCustomer() { ID = 102, Name = "Indu", Salary = 40000 };
            ComplexCustomer CC3 = new ComplexCustomer() { ID = 103, Name = "Chinky", Salary = 50000 };
            ComplexCustomer CC4 = new ComplexCustomer() { ID = 104, Name = "Pinky", Salary = 60000 };

            List<ComplexCustomer> complexCostomerlist = new List<ComplexCustomer>();
            complexCostomerlist.Add(CC1);
            complexCostomerlist.Add(CC4);
            complexCostomerlist.Add(CC3);
            complexCostomerlist.Add(CC2);

            /*Create an instance of System.Comparison delegate,and then pass the
            name of the function created for sorting.
            So,at this point "Comparision" delegate is pointing to our function
            that Contains logic to compare 2 ComplecCustomer Objects now pass the 
            delegate instance as an argument to sort method*/

            //Comparison<ComplexCustomer> CustomerComparer = new Comparison<ComplexCustomer>(CompareCustomer);

            //we can write whithout Creating an instance using delegate.

            Console.WriteLine("*********Before Sorting********");
            foreach (ComplexCustomer c in complexCostomerlist)
            {
                Console.WriteLine(c.ID);
            }

            //Comparison delegate passed as an argument
            // complexCostomerlist.Sort(delegate(ComplexCustomer x, ComplexCustomer y) { return x.ID.CompareTo(y.ID); });
            //We can even simplify as
            complexCostomerlist.Sort((x,y) => x.ID.CompareTo(y.ID));


            Console.WriteLine("*********After Sorting********");
            foreach (ComplexCustomer c in complexCostomerlist)
            {
                Console.WriteLine(c.ID);
            }

        }

        //Created a function whose signature matches with the System.Comparison delegate.
        //Contains the logic to Compare two Objects..

        //Since we are using delegate insted of creating an instance..
        /*public static int CompareCustomer(ComplexCustomer x, ComplexCustomer y)
        {
            //Comparing two ComplexCustomer Objects
            return x.ID.CompareTo(y.ID);
        }
        */
    }


}
