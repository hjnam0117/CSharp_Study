using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp01
{
    class Cat
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get;
            set;
        }
        private string color;
        public string Color { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Age = 10;
            nero.Color = "하얀색";
            Console.WriteLine($"{nero.Name} {nero.Age} {nero.Color}");
        }
    }
}
