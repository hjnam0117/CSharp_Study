using System;

using System.Collections.Generic;

using System.Dynamic;

using System.IO;

using System.Linq;

using System.Text;

using System.Text.Json;

using System.Threading.Tasks;



namespace ConsoleApp1

{



    class Student

    {

        public int STID { get; set; }

        public string Name { get; set; }

        public string Major { get; set; }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            string path = "C:\\Temp\\student.json";

            using (Stream sw = new FileStream(path, FileMode.Create))

            {

                Student student = new Student();

                student.STID = 12345;

                student.Name = "이순신";

                student.Major = "스마트팩토리";

                string jsonString = JsonSerializer.Serialize<Student>(student);

                byte[] jsonbytes = System.Text.Encoding.UTF8.GetBytes(jsonString);

                sw.Write(jsonbytes, 0, jsonbytes.Length);

            }



            using (Stream sr = new FileStream(path, FileMode.Open))

            {

                byte[] bytes = new byte[sr.Length];

                sr.Read(bytes, 0, bytes.Length);

                string jsonString = System.Text.Encoding.UTF8.GetString(bytes);



                Student nc2 = JsonSerializer.Deserialize<Student>(jsonString);

                Console.WriteLine(nc2.STID);

                Console.WriteLine(nc2.Name);

                Console.WriteLine(nc2.Major);

            }







        }

    }

}

