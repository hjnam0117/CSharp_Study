using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slice
{
    internal class Program
    {
        static void PrintArray(char[] array) //System.Array : 배열 모든 타입
        {
            foreach (char e in array)
                Console.Write(e);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1]; // Z(90)-A(65)+1
            for (int i = 0; i < array.Length; i++) 
                array[i] = (char)('A' + i);
            PrintArray(array);
        }
    }
}
