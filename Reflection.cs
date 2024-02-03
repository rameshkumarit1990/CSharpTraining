using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class CustomerReflection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerReflection() 
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public CustomerReflection(int ID, string Name) 
        {
            this.Id = ID;
            this.Name = Name;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("ID = {0}", this.Name);
        }
    }

    class Reflection
    {
        public static void RunProgram()
        {
            Type type = Type.GetType("FirstConsoleApp.CustomerReflection");
            Console.WriteLine("Full Name = {0}", type.FullName);
            Console.WriteLine("Full Name = {0}", type.FullName);
            Console.WriteLine("Full Name = {0}", type.FullName);
            Console.WriteLine();

            Console.WriteLine("Properties in Customer Reflection");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " +  property.Name);   
            }
            Console.WriteLine();

            Console.WriteLine("Methods in Customer Reflection class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();

        }
    }
}
