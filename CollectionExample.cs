using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class CollectionExample
    {
        public static void Main()
        {
            //insert data in array
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            Console.WriteLine(arr[2]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //List insert process
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Insert(0, 30);

            List<int> list1 = new List<int>();
            list1.Add(100);
            list1.Add(200);
            list1.Insert(0, 300);
            list.AddRange(list1);

        }
    }

}
