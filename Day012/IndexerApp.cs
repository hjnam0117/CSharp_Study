using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApp02
{
    class MyList
    {
        private int[] array;
        public MyList()
        {
            array = new int[3];
        }
        
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    //Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList(); //일반클래스
            for(int i=0; i<5; i++)
            {
                list[i] = i;
            }
            for(int i=0; i<list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
