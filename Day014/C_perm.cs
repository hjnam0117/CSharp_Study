using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_perm
{
    internal class Program
    {
        static int getN(int n)
        {
            if (n < 3) return n-1;
            else return (n-1)*(getN(n-1)+getN(n-2));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(getN(n));
        }
    }
}
