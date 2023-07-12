using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            // { 7.2, 9.3, 9.5, 9.6, 9.8, 9.1, 5.0, 9.3 }
            for (int i=0; i<n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(arr);

            double sum = 0, avg = 0;

            // 절사평균
            for (int i = k; i < n - k; i++)
            {
                sum += arr[i];
            }
            avg = (double) sum / (n-2*k);
            Console.WriteLine($"{avg:F2}");

            // 보정평균
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i < k) arr[i] = arr[k];
                if (i > n - k - 1) arr[i] = arr[n - k - 1];
                sum += arr[i];
            }
            avg = (double)sum / n;
            Console.WriteLine($"{avg:F2}");
        }
    }
}
