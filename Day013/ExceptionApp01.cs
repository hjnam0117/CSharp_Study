using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                /*
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }   
                */
                int a = 0;
                int result = a / 0;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("배열의 범위를 벗어난 예외가 발생하였습니다.");
                Environment.Exit(0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Console.WriteLine("종료");
        }
    }
}
