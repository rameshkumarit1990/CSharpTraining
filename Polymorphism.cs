using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Animal
    {
        public void AnimalEat()
        {
            Console.WriteLine("Animal Eating");
        }
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal make a sound");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Pig telling Oink Oink");
        }
    }

    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cat telling Meowwwwwwww");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog telling bowwhhhhh");
        }
    }
    class Polymorphism
    {
        public static void RunProgram()
        {
            Animal[] animals = new Animal[4];
            animals[0] = new Animal();
            animals[1] = new Pig();
            animals[2] = new Cat();
            animals[3] = new Dog();

            foreach (Animal ani in animals)
            {
                ani.AnimalSound();
                ani.AnimalEat();
            }

        }

    }
}
