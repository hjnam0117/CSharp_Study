using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPApp06
{
    class Car
    {
        public virtual void Run()
        {
            Console.WriteLine("차가 달리다");
        }
    }
    class SuperCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("슈퍼카가 달리다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            SuperCar superCar = new SuperCar();
            superCar.Run();
        }
    }
}
