using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp007
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그리다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Draw();
            Triangle triangle = new Triangle(); 
            triangle.Draw();
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            Circle circle = new Circle();
            circle.Draw();
        }
    }
}
