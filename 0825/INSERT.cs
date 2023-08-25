/* 
   Author : Ha, Sungho
   Date : 2023.08.08
   Context : Linq 문법을 이용하여 데이터베이스를 제어하는 문법입니다.
             DBMS는 오라클 11g Express로 선택하였기에 
             Nuget에서 받는 모듈은 Oracle.ManagedDataAccess.Core은 필수로 받아야 하고
             Linq로 제어하기 위해서는 Oracle.EntityFrameworkCore를 추가로 받아야 합니다.
             현재코드는 Person Table을 만들었습니다.
             CREATE TABLE Person (
               ID      INT PRIMARY KEY,
               NAME    VARCHAR2(30),
               AGE     INT,
               JOB     VARCHAR2(30)
             );

             코드의 context.Database.EnsureCreated()는 테이블을 생성하는 메소드 입니다.
             현재 알수없는 이유로 테이블이 생성되지 않아 원인을 파악하고 있습니다.
*/

using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp01
{
    public class Student
    {
        public int NO { get; set; }
        public string NAME { get; set; }
        public string MAJOR { get; set; }
        public string HOMTOWN { get; set; }
    }
    public class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()   //Primary key 지정
                .HasKey(p => p.NO);

            modelBuilder.Entity<Student>()   //Varchar2(20) 20크기를 정할 때
                .Property(p => p.NAME)
                .HasMaxLength(20);

            modelBuilder.Entity<Student>()
                .Property(p => p.MAJOR)
                .HasMaxLength(20);

            modelBuilder.Entity<Student>()
                .Property(p => p.HOMTOWN)
                .HasMaxLength(20);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated(); //테이블이 있다면 아무 동작도 하지 않습니다.
                // 데이터 삽입
                var students = new List<Student>
                {
                    new Student { NO = 100, NAME = "홍길동", MAJOR = "컴공", HOMTOWN = "안동" },
                    new Student { NO = 200, NAME = "이순신", MAJOR = "정통", HOMTOWN = "통영" },
                    new Student { NO = 300, NAME = "강감찬", MAJOR = "기계", HOMTOWN = "개성" },
                    new Student { NO = 400, NAME = "을지문덕", MAJOR = "멀티", HOMTOWN = "서울" }
                };

                context.Student.AddRange(students);
                context.SaveChanges();
                Console.WriteLine("데이터 삽입 성공!");
            }
        }
    }
}
