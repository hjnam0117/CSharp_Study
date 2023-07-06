using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";
            Console.WriteLine(greeting.Substring(0,5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(
                new string[] {" "}, StringSplitOptions.None);
            foreach(string element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
