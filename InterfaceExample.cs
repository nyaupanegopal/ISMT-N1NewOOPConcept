using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    interface IShape
    {
        void NoOfSide();
    }
    interface ISquare
    {
        int Area(int l);
        int Perimeter(int l);
    }
    interface IRectangle
    {
        int Area(int a, int b);
        int Perimeter(int a, int b);
    }
    public class Square1:ISquare,IShape
    {
        public int Area(int l)
        {
            return l * l;
        }
        public int Perimeter(int a)
        {
            return 4 * a;
        }
        public void NoOfSide()
        {
            Console.WriteLine("Square has 4 sides");
        }
    }
    
    public class Rectangle1 : IRectangle, IShape
    {
        public int Area(int l, int b)
        {
            return l * l;
        }
        public int Perimeter(int a, int b)
        {
            return 4 * a;
        }
        public void NoOfSide()
        {
            Console.WriteLine("Rectangle has 4 sides");
        }
    }
}
