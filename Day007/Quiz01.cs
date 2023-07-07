using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            for(int i=2; i<=100; i++)
            {
                flag = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    Console.Write(i + " ");
            }
            
            Console.WriteLine();
        }
    }
}
