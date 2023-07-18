using System; 
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pnumber { get; set; }

        public Student(int id, string name, string pnumber)
        {
            ID = id;
            Name = name;
            Pnumber = pnumber;
        }
    }
    internal class Program
    {
        static int N = 0;
        static List<Student> list = new List<Student>();
        static void Main(string[] args)
        {           
            while (true)
            {
                UIinit();       
                int n = int.Parse(Console.ReadLine());  
                Console.WriteLine();              
                switch (n)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        Console.Write("삭제할 학생의 ID를 입력하세요 : ");
                        int r = int.Parse(Console.ReadLine());                       
                        Delete(r);                                                
                        break;
                    case 3:
                        Print();                        
                        break;
                    case 4:
                        Console.Write("수정할 학생의 ID를 입력하세요 : ");
                        int m = Find(int.Parse(Console.ReadLine()));
                        Modify(m);                                      
                        break;
                    default:
                        Console.WriteLine("다시 입력해주세요");
                        break;
                }
            }
        }
        static void UIinit()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. 데이터 삽입");
            Console.WriteLine("2. 데이터 삭제");
            Console.WriteLine("3. 데이터 조회");
            Console.WriteLine("4. 데이터 수정");
            Console.Write("\n메뉴 : ");
        }
        static int Find(int id)
        {
            for(int i=0; i<list.Count; i++)
            {
                if (list[i].ID == id) return i;
            }
            Console.WriteLine("ID가 존재하지 않습니다");
            return -1;
        }
        static void Insert()
        {
            Console.Write("ID를 입력해 주세요 : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("이름을 입력해 주세요 : ");
            string name = Console.ReadLine();
            Console.Write("전화번호를 입력해 주세요 : ");
            string pnumber = Console.ReadLine();
            Student s = new Student(id, name, pnumber);
            list.Add(s);
            Console.WriteLine("\n데이터가 정상적으로 입력되었습니다.\n");
        }
        static void Delete(int r)
        {
            int remove = Find(r);        
            list.Remove(list[remove]);
        }
        static void Print()
        {
            Console.WriteLine($"ADDR_ID\t\tNAME\t\tHP");
            foreach (Student s in list)
            {
                Console.WriteLine($"{s.ID}\t\t{s.Name}\t\t{s.Pnumber}");
            }
            Console.WriteLine();
        }
        static void Modify(int m)
        {
            int modify = Find(m);
            Student std = list[modify];
            Console.Write("이름을 입력해 주세요 : ");
            string rename = Console.ReadLine();
            std.Name = rename;
            Console.Write("전화번호를 입력해 주세요 : ");
            string repnumber = Console.ReadLine();
            std.Pnumber = repnumber;
            Console.WriteLine("\n데이터가 정상적으로 수정되었습니다.\n");
        }
    }
}
