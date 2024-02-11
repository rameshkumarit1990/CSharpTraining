using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class StaticAndInstance
    {
        float Pi = 3.14f;
        int Radius;

        public StaticAndInstance(int radius)
        { 
         this.Radius = radius;
        }
        public StaticAndInstance()
        {
            Console.WriteLine("no parameter passed");
        }
        public void CalculateArea()
        {
            float area = this.Pi * this.Radius * this.Radius;
            Console.WriteLine("area of circle {0}", area);
        }

        public static void CalculateAreaCircle(int radius)
        {
            StaticAndInstance staticAndInstance = new StaticAndInstance(radius);
            float area = staticAndInstance.Pi * staticAndInstance.Radius * staticAndInstance.Radius;
            Console.WriteLine("area of circle {0}",area);
        }

        //This is how we need to use in main class
        //static void Main()
        //{
        //    Console.WriteLine("MainProgram");
        //    StaticAndInstance staticAndInstance = new StaticAndInstance(4);
        //    staticAndInstance.CalculateArea();
        //    StaticAndInstance.CalculateAreaCircle(6);
        //}
    }
}
