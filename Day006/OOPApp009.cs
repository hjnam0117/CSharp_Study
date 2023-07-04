using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace OOPApp009
{
    abstract class Shape
    {
        public abstract void Draw(); //추상 메소드는 구현x 
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //실세계
            Triangle t = new Triangle();
            t.Draw();

            Shape s = new Triangle();
            s.Draw();
        }
    }
}
