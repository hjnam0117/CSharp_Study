using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int inter = (n - 2) * 180;
            int exter = 180 * n - inter;
            Console.WriteLine($"{inter} {exter}"); 
        }
    }
}
