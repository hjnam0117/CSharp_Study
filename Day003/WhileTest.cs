using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 100 ~ 1 모두 1씩 마이너스 되면서 출력하라
            for(int i=0; i<100; i++)
            {
                Console.WriteLine(100 - i);
            }
        }
    }
}
