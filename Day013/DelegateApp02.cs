using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp02
{
    delegate int Compare(int a, int b);
    internal class Program
    {
        static int AsendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if(a==b) return 0;
            else return -1;
        }
        static int DsendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0, j = 0, temp = 0;
            for(i=0; i<DataSet.Length-1; i++)
            {
                for(j=0; j<DataSet.Length-(i+1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j+1]= DataSet[j];
                        DataSet[j]= temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // 배열생성
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("오름차순");
                              //Callback(AsendCompare)
            BubbleSort(array, new Compare(AsendCompare));
            // 출력
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();

            Console.WriteLine("내림차순");
            BubbleSort(array, new Compare(DsendCompare));
            // 출력
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
