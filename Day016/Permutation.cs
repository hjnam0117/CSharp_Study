using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++) {
                arr[i] = int.Parse(input[i]);
            }
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    for(int k=0; k<3; k++)
                    {
                        if (arr[i] != arr[j] && arr[i] != arr[k] && arr[j] != arr[k])
                            Console.WriteLine($"{arr[i]} {arr[j]} {arr[k]}");
                    }
                }
            }
        }
    }
}
