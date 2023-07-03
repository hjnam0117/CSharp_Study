using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatApp
{
    class Cat
    {
        private string name;
        private int age;
        private string color;
        public Cat()
        {
            name = "네로";
        }
        public void setName(string _name)
        {
            this.name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int _age)
        {
            this.age = _age;
        }
        public int getAge()
        {
            return age;
        }
        public void setColor(string _color)
        {
            this.color = _color;
        }
        public string getColor()
        {
            return color;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.setName("네로");
            cat.setAge(10);
            cat.setColor("검은색");
            Console.WriteLine($"이름 :{cat.getName()} 색깔 :{cat.getAge()} 나이 : {cat.getColor()}");
        }
    }
}
