
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkApp02
{
    public class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Hometown { get; set; }
    }
    public class StudentContext : DbContext
    {
        public DbSet<Student> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                context.Database.EnsureCreated(); //테이블이 있다면 아무 동작도 하지 않습니다.
                // 데이터 삽입
                var persons = new List<Student>
                {
                    new Student { No = 100, Name = "홍길동", Major = "컴공", Hometown = "안동" },
                    new Student { No = 200, Name = "이순신", Major = "정통", Hometown = "통영" },
                    new Student { No = 300, Name = "강감찬", Major = "기계", Hometown = "개성" },
                    new Student { No = 400, Name = "을지문덕", Major = "멀티", Hometown = "서울" }
                };

                context.Person.AddRange(persons);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 성공!");
            }
        }
    }
}
