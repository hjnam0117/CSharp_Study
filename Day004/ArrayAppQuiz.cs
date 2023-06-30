using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAppQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] BigAlpha = new char[26];
            char[] SmallAlpha = new char[26];

            char ch_1 = 'Z';
            char ch_2 = 'a';

            for (int i = 0; i < 26; i++)
            { 
                BigAlpha[i] = ch_1--;
                Console.Write(BigAlpha[i]+" ");
            }
            Console.WriteLine();

            for (int j = 0; j < 26; j++)
            {
                SmallAlpha[j] = ch_2++;
                Console.Write(SmallAlpha[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
