using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class PrimeNoCheck
    {
        public static void Main()
        {
            Console.WriteLine("Enter any no to check prime or not");
            int number = Convert.ToInt32(Console.ReadLine());
            bool status = false;
            //for (int i = 2; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        status = false;
            //        break;
            //    }
            //    else
            //        status = true;

            //}
            //if (status == true)
            //{
            //    Console.WriteLine("Prime No");
            //}
            //else Console.WriteLine("Not Prime");
            //int i = 2;
            //while (i < number)
            //{
            //    if (number % i == 0)
            //    {
            //        status = false;
            //        break;
            //    }
            //    else
            //        status = true;

            //}
            //if (status == true)
            //{
            //    Console.WriteLine("Prime No");
            //}
            //else Console.WriteLine("Not Prime");
            //i++;
            int i = 2;
            do
            {
                {
                    if (number % i == 0)
                    {
                        status = false;
                        break;
                    }
                    else
                        status = true;

                }
                if (status == true)
                {
                    Console.WriteLine("Prime No");
                }
                else Console.WriteLine("Not Prime");
                i++;
            } while (i<number);
        }



    }
}
