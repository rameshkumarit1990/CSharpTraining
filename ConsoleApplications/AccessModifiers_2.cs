using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Bakery
    {
        private string _name;
        //private members are accessable only inside that perticular class

        public string Name { get { return _name; } set { _name = value; } }
    }

    public class Customer2
    {
        //protected members are accessable inside its own class 
        //and its derived classes only

        protected int _id;
    }
    public class Customer3 : Customer2
    {
        public void printID()
        {
            Customer3 customer3 = new Customer3();
            customer3._id = 100;
            Console.WriteLine(customer3._id);
            this._id = 400;
            Console.WriteLine(_id);
            base._id = 500;
            Console.WriteLine(_id);

        }
    }

    //for AccessModifier_3
    public class InternalClass2
    {
        internal protected int RollNo = 100;
    }
    class AccessModifiers_2
    {
        public static void RunProgram()
        {
            Bakery bakery = new Bakery();
            //Console.WriteLine(bakery._name);//throws a compiler error due to protection
            Customer3 customer3 = new Customer3();
            customer3.printID();
        }
    }
}
