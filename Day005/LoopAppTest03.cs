using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAppTest03
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            do
            {
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("1 입력");
                        break;
                    case 2:
                        Console.WriteLine("2 입력");
                        break;
                    default:
                        Console.WriteLine("1,2 외");
                        break;
                }
                if (i == 100)
                {
                    Console.WriteLine("100 입력 종료");
                    break;
                }
            } while (true);
        }
    }
}
