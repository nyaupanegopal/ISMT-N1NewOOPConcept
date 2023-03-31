using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class ForeachLoopExample
    {
        public static void Main()
        {
            string[] arr = new string[5];
            arr[0] = "Mitra";
            arr[1] = "Purna";
            arr[2] = "Sonik";
            arr[3] = "Rubin";
            arr[4] = "...";

            foreach (string name in arr)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
