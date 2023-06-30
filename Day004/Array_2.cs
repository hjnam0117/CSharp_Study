using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] result = new int[8, 9];
            for (int i=0; i<8; i++)
            {
                for(int j=0; j<9; j++)
                {
                    result[i, j] = (i+2) * (j+1);
                    Console.Write(result[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
