using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            //특정 범위의 정수
            Random r = new Random();
            int[] arr = new int[6];
            int num, bonus;
            Console.Write("로또번호 : ");           
            for (int i = 0; i < 6; i++)
            {
                num = r.Next(1, 46);              
                // 1부터 45까지 생성됨 
                while (arr.Contains(num))
                {
                    num = r.Next(1, 46);
                }
                arr[i] = num;
                for(int j=0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }         
            for (int i = 0; i < 6;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            bonus = r.Next(1, 46);
            while (arr.Contains(bonus))
            {
                bonus = r.Next(1, 46);
            }
            Console.WriteLine($"보너스번호 : {bonus}");
        }
    }
}
