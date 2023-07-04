using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp12
{
    class Cat
    {
        public Cat()
        {
            Console.WriteLine("객체의 생성자가 호출되었습니다.");
        }
        ~Cat()
        {
            Console.WriteLine("객체의 소멸자가 호출되었습니다.");
        }
    }
    class RussianBlue : Cat
    {
        public RussianBlue()
        {
            Console.WriteLine("RussianBlue 생성자가 호출되었습니다.");
        }
        ~RussianBlue()
        {
            Console.WriteLine("RussianBlue 소멸자가 호출되었습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            RussianBlue rb = new RussianBlue();
        }
    }
}
