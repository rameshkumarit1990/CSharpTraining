using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class _82GenericQueue
    {
        public static void RunProgram()
        {
            QueueCustomer customer1 = new QueueCustomer() { Name = "Pinky", Id = 101, Gender = "Female" };
            QueueCustomer customer2 = new QueueCustomer() { Name = "tinky", Id = 102, Gender = "male" };
            QueueCustomer customer3 = new QueueCustomer() { Name = "vinky", Id = 103, Gender = "male" };
            QueueCustomer customer4 = new QueueCustomer() { Name = "dinky", Id = 104, Gender = "male" };
            QueueCustomer customer5 = new QueueCustomer() { Name = "finky", Id = 105, Gender = "Female" };
            Queue<QueueCustomer> queue1 = new Queue<QueueCustomer>();
            queue1.Enqueue(customer1);
            queue1.Enqueue(customer2);
            queue1.Enqueue(customer3);
            queue1.Enqueue(customer4);
            queue1.Enqueue(customer5);

            QueueCustomer c1 = queue1.Dequeue();
            Console.WriteLine($"{c1.Id} , {c1.Name}");
            Console.WriteLine($"total items = {queue1.Count}");

            foreach (QueueCustomer item in queue1)
            {
                Console.WriteLine($"{item.Name},{item.Id},{item.Gender}");
            }

            QueueCustomer c2 = queue1.Peek();
            Console.WriteLine($"{c2.Id} , {c2.Name}");
            Console.WriteLine($"total items = {queue1.Count}");

            Console.WriteLine(queue1.Contains(customer4));
        }
    }
    public class QueueCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
