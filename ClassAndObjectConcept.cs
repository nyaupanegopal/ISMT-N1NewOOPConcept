//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace N1FirstApp
//{
//    public class Dog
//    {
//        //field , Properties
//        string breed;
//        string color;
//        int age;
//        string gender;
//        string owner;

//        //behavior
//        public int Eat(int a)
//        {
//            Console.WriteLine("Dog Eats " + a + "Kg of Meat");
//            return a / 1000;
//        }
//        public double Sum(int a, int b)
//        {
//            return a + b * 0.1;
//        }
//        //public Dog()
//        //{
//        //    age = 1;
//        //    breed = "local breed";
//        //    Console.WriteLine("dog object is created");
//        //}
//        public Dog(int a, sting g, string o)
//        {
//            age = a;
//            gender = g;
//            owner = o;
//        }
//        public Dog()
//        {

//        }
//        public static void Main()
//        {
//            Dog lucie = new Dog(2, "F");
//            lucie.age = 2;
//            lucie.gender = "F";
//            lucie.owner = "Sandeep";
//            lucie.breed = "GS";
//            lucie.color = "black";
//            int totalkg = lucie.Eat(3000);
//            Dog tom = new Dog();
//            tom.age = 3;
//            tom.gender = "M";
//        }

//    }
//}
