using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //특정 범위의 정수
            Random r = new Random();
            int num, bonus;
            Console.Write("로또번호 : ");
            for (int i = 0; i < 6; i++)
            {
                num = r.Next(1, 46); // 1부터 45까지 생성됨
                Console.Write(num + " ");
            }
            Console.WriteLine();
            num = r.Next(1, 46);
            Console.WriteLine($"보너스번호 : {num}");
        }
    }
}
