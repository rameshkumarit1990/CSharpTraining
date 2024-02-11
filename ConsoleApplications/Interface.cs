using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    interface IAnimal
    {
        void AnimalSound();
        void Eating(string quantity);
    }

    interface IHuman
    {
        void HumanTalk();
        void Eating(string quantity);
    }

    class Cow : IAnimal, IHuman
    {
        public void AnimalSound()
        {
            Console.WriteLine("Ammbbaaa...Ammbbaaaa");
        }
        public void Eating(string quantity)
        {
            Console.WriteLine("I am cow and i eat grass of {0}",quantity);
        }
        public void HumanTalk()
        {
            Console.WriteLine("I am human and i talk to cow");
        }
        void IHuman.Eating(string quantity)
        {
            Console.WriteLine("i am human and i eat {0}",quantity);
        }

    }
    class Interface 
    {
        public static void RunProgram()
        {
            Cow cow = new Cow();
            cow.AnimalSound();
            cow.Eating("2 bundles");
            cow.HumanTalk();
            ((IHuman)cow).Eating("thali");
        }
    }
}