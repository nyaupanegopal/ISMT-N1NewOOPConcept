using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class SumofEvenNo
    {
        public static void Main()
        {
            

            int result=0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    result = result + i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
