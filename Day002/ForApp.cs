using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // 1~100까지 합을 출력
            for(int i=1; i<=100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            // 5050
        }
    }
}
