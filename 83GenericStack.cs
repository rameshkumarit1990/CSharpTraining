using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class _83GenericStack
    {
        public static void RunProgram()
        {
            QueueCustomer customer1 = new QueueCustomer() { Name = "Pinky", Id = 101, Gender = "Female" };
            QueueCustomer customer2 = new QueueCustomer() { Name = "tinky", Id = 102, Gender = "male" };
            QueueCustomer customer3 = new QueueCustomer() { Name = "vinky", Id = 103, Gender = "male" };
            QueueCustomer customer4 = new QueueCustomer() { Name = "dinky", Id = 104, Gender = "male" };
            QueueCustomer customer5 = new QueueCustomer() { Name = "finky", Id = 105, Gender = "Female" };

            Stack<QueueCustomer> stackCustomers = new Stack<QueueCustomer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            Console.WriteLine("before" + stackCustomers.Count());

            foreach (QueueCustomer item in stackCustomers)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.Gender}");
            }

            QueueCustomer S1 = stackCustomers.Pop();
            Console.WriteLine($"{S1.Id},{S1.Name},{S1.Gender}");

            Console.WriteLine("after" + stackCustomers.Count());

            QueueCustomer S2 = stackCustomers.Peek();
            Console.WriteLine($"{S2.Id},{S2.Name},{S2.Gender}");

        }
    }
}
