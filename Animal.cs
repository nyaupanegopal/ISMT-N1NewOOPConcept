using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class Animal
    {
        public string Name;
        public int Age;
        public int Gender;
        public int NoofLegs;

        public void Eat()
        {
            Console.WriteLine("Eat Method");
        }
    }
    internal class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog Barks");
        }
        public static void Main()
        {
            Dog lucie=new Dog();
            lucie.Bark();
            lucie.Name = "";
            lucie.Age = 3;
            lucie.Gender = 1;
            lucie.Eat();
        }
    }
}
