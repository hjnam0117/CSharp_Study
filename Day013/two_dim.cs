using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[,] arr = new int[3, 4];
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 4; j++)
                    arr[i, j] = int.Parse(input[4*i + j]);
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(arr[i, j]+" ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                    Console.Write(arr[i, j]+" ");
                Console.WriteLine();
            }
        }
    }
}
