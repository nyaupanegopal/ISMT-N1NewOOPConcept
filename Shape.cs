using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1FirstApp
{
    internal abstract class Shape
    {
        public abstract int Area(int l, int b);
        public abstract int Perimeter(int l,int b);
    }
    internal class Square : Shape
    {
        public override int Area(int l, int b)
        {
            return l * b;
        }
        public override int Perimeter(int l, int b)
        {
            return 4*l;
        }
    }
    internal class Rectangle : Shape
    {
        public override int Area(int l, int b)
        {
            return l * b;
        }
        public override int Perimeter(int l, int b)
        {
            return 4 * l;
        }
    }
    public class ProgramNew
    {
        public static void Main()
        {
            Shape shape = new Square();
            int SquareArea=shape.Area(10, 10);
            Console.WriteLine("Area of Square= "+SquareArea);
            int SquarePerimeter=shape.Perimeter(10, 10);
            Console.WriteLine("Perimeter of Square=" + SquarePerimeter);

            Shape shape2 = new Rectangle();
            int RectangleArea = shape2.Area(10, 10);
            Console.WriteLine("Area of Rectangle= " + RectangleArea);
            int RectanglePerimeter = shape2.Perimeter(10, 10);
            Console.WriteLine("Perimeter of Square=" + RectanglePerimeter);
            Console.ReadLine();
        }
    }
}
