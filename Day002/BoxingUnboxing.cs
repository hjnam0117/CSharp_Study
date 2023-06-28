using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; // Boxing
            int c = (int)b; //UnBoxing

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.141592;
            object y = x;
            double z = (double)y;
        }
    }
}
