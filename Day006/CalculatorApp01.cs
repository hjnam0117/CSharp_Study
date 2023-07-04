using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogApp
{
    class Dog
    {
        private string name;
        public Dog(string _name)
        {
            this.name = _name;
        }
        public string getName() 
        { 
            return this.name; 
        }
        public string Eat()
        {
            return "먹습니다.";
        }
        public string Play()
        {
            return "뛰어놀다.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("톰");
            Console.WriteLine($"{dog.getName()}이 음식을 {dog.Eat()}");
            Console.WriteLine($"{dog.getName()}이 {dog.Play()}");
        }
    }
}
