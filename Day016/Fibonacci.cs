using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1)+ Fibonacci(n-2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }
}
