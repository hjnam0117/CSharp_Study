using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N ? ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int cnt = 1, p = 1;
            int row = 0, col = -1;
            for (int i = 0; i < n; i++) arr[row, ++col] = cnt++;
            for (int i=1; i<n; i++)
            {
                for (int j=0; j< n-i; j++)
                {
                    if (p == 1) row++;
                    else row--;
                    arr[row, col] = cnt++;
                }
                p *= -1;
                for (int j=0; j<n-i; j++)
                {
                    if (p == -1) col--;
                    else col++;
                    arr[row, col] = cnt++;
                }
            }                              
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
