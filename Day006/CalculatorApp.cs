using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp01
{
    class Calculator
    {
        private string x;
        // 1. 멤버변수
        // 2. 생성자
            //~ 디폴트 생성자는 안만들면 자동으로 만들어진다.
            //~ 단, 인자가 있는 생성자가 1개라도 있으면 자동으로 만들어지지 않는다.
        public Calculator() { }
        public Calculator(string _x)
        {
            this.x = _x;
        }
        // 3. 멤버 메소드
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator("홍길동");
        }
    }
}
