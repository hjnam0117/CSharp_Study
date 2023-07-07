using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N ? ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int row=0, col=1;
            for(int i = 0; i < n*n; i++)
            {
                arr[row, col] = i+1;
                if ((i + 1) % n == 0) row++;
                else
                {
                    if (row < 1) row = n - 1;
                    else row--;
                    if (col >= n - 1) col = 0;
                    else col++;
                }
             }
            for(int i=0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
