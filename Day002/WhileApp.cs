using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 200)
            {
                Console.Write(i + " ");
                // i = i + 1;
                // i += 1;
                i++; // 후치연산자
            }
        }
    }
}
