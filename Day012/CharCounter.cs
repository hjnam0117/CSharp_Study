using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountApp
{
    internal class Program
    {
        public static int CharCounter(char[] arr, char ch)
        {
            int n = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == ch) n++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("문자열 : ");
            String str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Console.Write("문자 : ");
            String str2 = Console.ReadLine();
            char ch = str2.ElementAt(0);
            Console.Write("결과 : ");
            Console.WriteLine(CharCounter(arr, ch));
        }
    }
}
