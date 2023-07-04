using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp02
{
    class Calculator
    {
        public int executeTotalScore(int a, int b, int c)
        {
            return a + b + c;
        }
        public double excuteAvg(int a, int b, int c)
        {
            return (double)(a + b + c) / 3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.Write("국어 : ");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("영어 : ");
            int eng = int.Parse(Console.ReadLine());
            Console.Write("수학 : ");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine($"총점 : {calculator.executeTotalScore(kor, eng, math)}");
            Console.WriteLine($"평균 : {calculator.excuteAvg(kor, eng, math)}");
        }
    }
}
