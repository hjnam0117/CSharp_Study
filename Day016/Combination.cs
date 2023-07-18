using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4};
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    if (i < j)
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                }
            }
        }
    }
}
