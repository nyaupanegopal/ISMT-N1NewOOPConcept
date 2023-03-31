using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal class RelationClassOverload
    {
        int a ;
        int b ;
        public static void Main()
        {
            RelationClassOverload obj1=new RelationClassOverload();
            obj1.a = 10;
            obj1.b = 20;
            RelationClassOverload obj2 = new RelationClassOverload();
            obj2.a = 100;
            obj2.b = 200;
            var result=obj1 > obj2;
        }
        public static bool operator >(RelationClassOverload obj1, RelationClassOverload obj2)
        {
            if(obj1.a<obj2.a)
            {
                return false;
            }
            else if(obj1.b<obj2.b)
            {
                return false;
            }
            else return true;
        }
        public static bool operator <(RelationClassOverload obj1, RelationClassOverload obj2)
        {
            if (obj1.a > obj2.a)
            {
                return false;
            }
            else if (obj1.b > obj2.b)
            {
                return false;
            }
            else return true;
        }
    }
}
