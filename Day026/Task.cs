using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 1~100 더하기  
            int sum = 0;
            Action someAction = () =>
            {
                              
                for(int i=1; i<=100; i++)
                {
                    sum += i;
                }                
                Console.WriteLine(sum);
            };

            Task myTask1 = new Task(someAction);
            myTask1.Start();
            myTask1.Wait();

            //2. A~Z 출력
            Task myTask2 = Task.Run(() =>
            {
                for (int i = 'A' ; i <= 'Z'; i++)
                    Console.Write((char)i + " ");
            });
            myTask2.Wait();
            Console.WriteLine("\nmain 종료!!");

        }
    }
}
