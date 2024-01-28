using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    sealed class Customer
    {
        public void BuyProduct()
        {
            Console.WriteLine("Customer pays for  a product");
            Console.WriteLine("Customer buys the product");
        }
    }
    interface ICompany
    {
        public void CreateProdect();
        public void AddItem();
        public void RemoveItem();
        public void AllItems();
    }
    //Abstract class: is a restricted class that cannot be used to
    //create objects (to access it, it must be inherited from another class).
    public abstract class Store: ICompany
    {
        public void CreateProdect()
        {
            Console.WriteLine("New Product Created");
        }

        public void AllItems()
        {
            Console.WriteLine("All items of store");
        }

        //we make the method abstract if we cant provide implementation 
        public abstract void AddItem();
        public abstract void RemoveItem();

    }

    public class Manager : Store
    {
        //we override the abstract methods to provide implementation
        public override void AddItem()
        {
            Console.WriteLine("Added item to store by Manager ");
            AllItems();
        }
        //methods from store or inerface can only be override but can 
        //make them base 
        public override void RemoveItem()
        {
            Console.WriteLine("Item Removeby Manager");
        }

    }

    public class AssManager : Manager
    {
        public override void RemoveItem()
        {
            Console.WriteLine("Item Removed by AssManager");
        }
    }
    class Abstraction
    {
        public static void RunProgram()
        {
            Store manager = new Manager();
            manager.AddItem();
            manager.RemoveItem();
 
            //we cant create an instance of an abstract class..
            //Store store = new Store();
            //store.AllItems();
            AssManager assManager = new AssManager();
            assManager.RemoveItem();
            Console.WriteLine("prodect by assistent manager");
            assManager.CreateProdect();

            Customer customer = new Customer();
            customer.BuyProduct();

        }
    }
}
