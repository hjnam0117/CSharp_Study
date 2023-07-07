using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnArray
{
    internal class Program
    {
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            int[,] s2 = new int[2, 2];

            // 1. 정렬
            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            //2.Rank 배열의 차원을 반환
            Console.WriteLine(scores.Rank + "차원");
            Console.WriteLine(s2.Rank + "차원");

            // 3.BinarySearch 이진탐색
            Console.WriteLine($"이진탐색 81 : " + Array.BinarySearch<int>(scores, 81));

            // 4.선형탐색 Linear Search
            Console.WriteLine($"선형탐색 90 : " + Array.IndexOf(scores, 80));

            // 5.조건검사
            Console.WriteLine(Array.TrueForAll<int>(scores, CheckPassed));

            int index = Array.FindIndex<int>(scores, (score) => score >= 60);   
            Console.WriteLine("index : " + index);

            // 6. 배열 크기 재조정
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine("변경된 배열의 길이 : "+scores.Length);

            // 7. 배열요소 초기화
            Array.ForEach<int>(scores, new Action<int>(Print));
            Array.Clear(scores, 3, 7);
            Console.WriteLine();
            Array.ForEach<int>(scores, new Action<int>(Print));

            // 8. 배열 자르기
            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Console.WriteLine();
            Array.ForEach<int>(sliced, new Action<int>(Print));
        }
    }
}
