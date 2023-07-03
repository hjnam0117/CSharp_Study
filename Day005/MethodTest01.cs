using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest01
{
    internal class Program
    {
        static double Avg(int kor, int eng, int math)
        {
            return (double)(kor + eng + math) / 3.0;
        }
        static void Main(string[] args)
        {
            int[] score = new int[3];
            for(int i = 0; i < 3; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
            }
            double result = Avg(score[0], score[1], score[2]);
            Console.WriteLine(result);
        }
    }
}
