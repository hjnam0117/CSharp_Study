
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string input = Console.ReadLine();
            
            string reversed = "";
            for (int i = input.Length-1; i >=0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed);

            //2
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            reversed = new string(array);
            Console.WriteLine(reversed);

            //3
            Stack<char> stack = new Stack<char>(input);
            reversed = string.Join("", stack);
            Console.WriteLine(reversed);

            //4
            reversed = new string(input.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
