using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class ParamConstructor
    {
        
        int result;
        public ParamConstructor(int a, int b)
        {
            result = a+b;
            Console.WriteLine("user defined construcor called");
        }
        public static void Main()
        {
            ParamConstructor obj = new ParamConstructor(10,20);
            Console.WriteLine(obj.result);
        }
    }
}
