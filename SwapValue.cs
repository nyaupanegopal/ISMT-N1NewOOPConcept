using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class SwapValue
    {
        public static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"a={a},b={b}");
            SwapValue swap=new SwapValue();
            //swap.Swap(10.9, "9");
            Console.WriteLine($"a={a},b={b}");
            Console.ReadLine();
        }

        public void Swap( int a,  int b)
        {
            
        }
        public void Swap(string a, int b)
        {
            
        }
        public void Swap(int a, string b)
        {

        }
        public void Swap(string a, string b)
        {

        }
        public void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public void Swap(ref int a, ref int b,int c)
        {
             c = a;
            a = b;
            b = c;
        }
    }
}
