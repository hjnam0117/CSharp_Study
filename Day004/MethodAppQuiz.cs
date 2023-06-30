using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAppQuiz
{
    internal class Program
    {
        static int plus(int a, int b)
        {
            return a + b;
        }
        static int minus(int a, int b)
        {
            return a - b;
        }
        static int multiple(int a, int b)
        {
            return a * b;
        }
        static double divide(int a, int b)
        {
            return (double)a / b;
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result1, result2, result3;
            double result4;

            result1 = plus(number1, number2);
            result2 = minus(number1, number2);
            result3 = multiple(number1, number2);
            result4 = divide(number1, number2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3); 
            Console.WriteLine(result4);
        }
    }
}
