using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberApp
{
    internal class Program
    {
        static bool IsPerfect(int num)
        {
            int sum = 0;
            for(int i=1; i<num; i++)
            {
                if (num % i == 0) sum += i;
            }
            if (sum == num) return true;
            else return false;
        } 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPerfect = IsPerfect(n);
            if (isPerfect) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
