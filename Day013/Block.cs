using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for 4개
            string[] input;
            int[,] arr = new int[9, 9];
            int sum = 0;
            for(int i=0; i<9; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j=0; j<9; j++)
                {
                    arr[i, j] = int.Parse(input[j]);                   
                }  
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum = 0;
                    for (int k = i*3 ; k < i*3 + 3; k++)
                    {
                        for (int n = j*3; n < j*3 + 3; n++)
                        {
                            sum += arr[k, n];
                        }
                    }
                    Console.WriteLine(sum);                    
                }               
            }                       
        }
    }
}
