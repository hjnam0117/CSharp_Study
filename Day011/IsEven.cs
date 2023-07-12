using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberApp02
{
    internal class Program
    {
        public static bool IsEven(int x)
        {
            int even = getEven(x);
            if(even%2 == 0) return true;
            else return false;
        }
        public static int getEven(int x)
        {
            int divisor = 0;
            for(int i=2; i<x; i++)
            {
                if (x % i == 0) divisor++;
            }
            return divisor + 2;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i=a; i<=b; i++)
            {
                if (IsEven(i)) cnt++; 
            }
            Console.WriteLine(cnt);
        }
    }
}
