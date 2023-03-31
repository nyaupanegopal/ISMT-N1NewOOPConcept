using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class Calculator
    {
        public static void Main()
        {
            int a = 10;
            int b=10;
            Calculator cal=new Calculator();
            Console.WriteLine(a);
            int sumresult=cal.Sum(ref a, out b);
            Console.WriteLine(a);
            Console.WriteLine("Sum of two no=:" + sumresult);
            int subresult=cal.Sub(a, b);
            Console.WriteLine("Subtract REsult:" + subresult);
        }
        public int Sum(ref int a, out int b)
        {
            
            Console.WriteLine(a);
            b = 100;
            Console.WriteLine(a);
            int result = a + b;
            return result;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }

    }
}
