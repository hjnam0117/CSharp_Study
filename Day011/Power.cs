using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    internal class Program
    {
        static int Pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++) result *= x;
            return result;
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Pow(x, y));
        }
    }
}
