using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp01
{
    class MyClass
    {
        private delegate void RunDelegate(int i);
        private void RunThis(int val)
        {
            //10진수 출력 1024
            Console.WriteLine(val);
        }
        private void RunThat(int val)
        {
            //출력 16진수 1024 -> 400
            Console.WriteLine($"{val:X}");
        }
        public void Perform()
        {
            //델리게이트 객체 생성
            RunDelegate run = new RunDelegate(RunThis);
            //10진수 출력
            run(1024);
            //16진수 출력
            run = RunThat;
            //run = new RunDelegate(RunThat);
            run(1024);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {          
            MyClass mc = new MyClass();
            mc.Perform();
        }
    }
}
