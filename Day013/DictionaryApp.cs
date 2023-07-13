using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    internal class Program
    {
        static string Login(Dictionary<string, string> user, string id, string pw)
        {
            if (user["userId"] == id && user["password"] == pw)
                return "로그인 성공";
            else return "로그인 실패";
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> user = new Dictionary<string, string>
            {
                { "userId", "admin" },
                { "password", "1234" }
            };

            Console.Write("ID 입력 : ");
            string id = Console.ReadLine();
            Console.Write("PW 입력 : ");
            string pw = Console.ReadLine();

            Console.WriteLine(Login(user, id, pw));
        }
    }
}
