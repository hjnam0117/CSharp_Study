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
            for(int i=100; i>0; i--)
            {
                Console.WriteLine(i);
            }
            // 1 ~ 100 중 짝수를 출력하라
            for (int j=2; j<=100; j++)
            {
                if(j%2 == 0)
                {
                    Console.WriteLine(j);
                }
            }

            // 1 ~ 100 중 홀수를 출력하라
            int k = 0;
            while (k < 100)
            {
                if (k%2 != 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
        }
    }
}
