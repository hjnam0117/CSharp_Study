using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력하세요 : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0;
            
            for(int i=0; i<str.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                    cnt1++;
                else if (arr[i] >= 'a' && arr[i] <= 'z')
                    cnt2++;
                else if (arr[i] >= '0' && arr[i] <= '9')
                    cnt3++;
                else
                    cnt4++;
            }
            Console.WriteLine($"알파벳 대문자 : {cnt1}");
            Console.WriteLine($"알파벳 소문자 : {cnt2}");          
            Console.WriteLine($"숫자 : {cnt3}");
            Console.WriteLine($"특수문자 : {cnt4}");
        }
    }
}
