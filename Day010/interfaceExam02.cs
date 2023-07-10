using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExam02
{
    // 1. IWeapon 인터페이스
    interface IWeapon
    {
        string Attack();
    }
    // 2. IBow 인터페이스, 메소드 --> Attack()
    interface IBow : IWeapon
    {
    }
    // 3. Hero --> member변수 Name Property
    class Hero
    {
        public string Name { get; set; }
    }
    // 4. Knight --> 아더기사를 생성해야함
    class Knight : Hero, IBow
    {
        public Knight(string name)
        {
            Name = name;
        }

        public string Attack()
        {
            return "활을 쏩니다.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arthur = new Knight("아더");
            Console.WriteLine($"{arthur.Name}가 {arthur.Attack()}");
        }
    }
}
