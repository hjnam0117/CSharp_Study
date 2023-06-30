using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanQuiz
{
    internal class Program
    {
        static void Main()
        {
            double mean = 0;
            Mean(1, 2, 3, 4, 5, ref mean);
            Console.WriteLine($"평균 : {mean}");
        }
        public static void Mean(
            double a, double b, double c,
            double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / (double) 5;
        }
    }
}
