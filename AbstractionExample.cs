using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal abstract class CalculatorAbstract
    {
        //public abstract int MyProperty { get; set; }
        //public virtual int Sum(int a,int b)
        //{
        //    return a + b;
        //}
        public abstract int Sum(int a, int b, int c);
        
        
    }
    class Test:CalculatorAbstract
    {
        public int MyProperty { get; set; }
        //public override int Sum(int a, int b)
        //{
        //    //MyProperty = 10;
        //    return base.Sum(a,b);
        //}
        public override int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public static void Main()
        {
            CalculatorAbstract t = new Test();
            
            var result=t.Sum(1,2,3);
            Console.WriteLine(result);
        }
        
    }
}
