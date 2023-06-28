using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = '반';
            char b = '가';
            char c = '워';

            char[] greet = new char[3];
            greet[0] = '반';
            greet[1] = '가';
            greet[2] = '워';

            for(int i=0; i<greet.Length; i++)
            {
                Console.Write(greet[i]);
            }
            Console.WriteLine();

            string greet2 = "행복\n하세\n요!!!";
            Console.WriteLine(greet2);
        }
    }
}
