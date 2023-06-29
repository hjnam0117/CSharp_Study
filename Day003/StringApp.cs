using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            //IndexOf
            Console.WriteLine($"{greeting.IndexOf("Morning")}");
            Console.WriteLine($"{greeting.IndexOf("d")}");

            //LastIndexOf()
            Console.WriteLine($"{greeting.LastIndexOf("Good")}");
            Console.WriteLine($"{greeting.LastIndexOf("o")}");
        }
    }
}
