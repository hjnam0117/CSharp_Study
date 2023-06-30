using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByValue
{
    internal class Program
    {
        static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"{a} {b}");
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;            
            Console.WriteLine($"{x} {y}");
            Swap(x, y);
            Console.WriteLine($"{x} {y}");
        }
    }
}
