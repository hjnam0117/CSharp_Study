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
            Console.WriteLine($"IndexOf 'Morning' : {greeting.IndexOf("Morning")}");
            Console.WriteLine($"IndexOf 'd' : {greeting.IndexOf("d")}");

            //LastIndexOf()
            Console.WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");
            Console.WriteLine($"LastIndexOf 'o' : {greeting.LastIndexOf("o")}");

            //StartsWith()
            Console.WriteLine($"StartsWith 'Good' : {greeting.StartsWith("Good")}");
            Console.WriteLine($"StartsWith 'Morning' : {greeting.StartsWith("Morning")}");

            //EndsWith()
            Console.WriteLine($"EndsWith 'Good' : {greeting.EndsWith("Good")}");
            Console.WriteLine($"EndsWith 'Morning' : {greeting.EndsWith("Morning")}");

            //Contains()
            Console.WriteLine($"Contains 'Evening' : {greeting.Contains("Evening")}");
            Console.WriteLine($"Contains 'Morning' : {greeting.Contains("Morning")}");

            //Replace()
            Console.WriteLine($"Replace Evening : {greeting.Replace("Morning", "Evening")}");
        }
    }
}
