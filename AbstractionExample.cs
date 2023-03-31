using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class CalculatorAbstract
    {
        public virtual int Sum(int a,int b)
        {
            return a + b;
        }
        
    }
    class Test:CalculatorAbstract
    {
        public override int Sum(int a, int b)
        {
            return a+2*b;
        }
        public static void Main()
        {
            CalculatorAbstract t = new Test();
            var result=t.Sum(1,2);
            Console.WriteLine(result);
        }
        
    }
}
