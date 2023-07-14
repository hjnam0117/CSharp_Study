using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain_Easy
{
    internal class Program
    {
        delegate void ThereisAsFire(string location);
        public static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났어요? 주소는 {location}");
        }
        public static void ShotOut(string location)
        {
            Console.WriteLine($"피하세요 {location}에 불이 났어요.");
        }
        public static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나가세요.");
        }
        static void Main(string[] args)
        {
            ThereisAsFire Fire = new ThereisAsFire(Call119);
            Fire += new ThereisAsFire(ShotOut);
            Fire += new ThereisAsFire(Escape);
            Fire -= new ThereisAsFire(ShotOut);
            Fire("우리집");
        }
    }
}
