using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // 1단계
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2단계
            for (int i=n; i>0; i--)
            {
                for (int j=i; j>0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 3단계
            for (int i=0; i<n; i++)
            {
                for (int j=n-i-1; j>0; j--)
                {
                    Console.Write(" ");
                }
                for (int k=0; k<=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 4단계
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = n-i-1; j>=0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 5단계
            for (int i=0; i<n/2+1; i++)
            {
                for (int k=n/2-i; k>0; k--)
                {
                    Console.Write(" ");
                }
                for (int j=0; j<i*2+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i=0; i<n/2; i++)
            {
                for (int j=0; j<i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k=n-2*(i+1); k>0; k--)
                {
                    Console.Write("*");
                }            
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
