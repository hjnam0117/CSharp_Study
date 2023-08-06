using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace StreamQuiz03

{

    internal class Program

    {

        static void Main(string[] args)

        {

            /*﻿FileMode.Open 한 후 복사를 해주세요. */

            string APath = "C:\\Temp\\a.txt";

            string BPath = "C:\\Temp\\b.txt";

            string readValue;



            using (Stream st1 = new FileStream(APath, FileMode.Open))

            {

                byte[] openbyte = new byte[st1.Length];

                for (int i = 0; st1.Position < st1.Length; i++)

                    openbyte[i] = (byte)st1.ReadByte();



                readValue = Encoding.UTF8.GetString(openbyte);

            }



            //읽어오라는 것은 그 내용을 여기다가 생성을 하라는 건가요..?

            using (Stream st1 = new FileStream(BPath, FileMode.Create))

            {

                StreamWriter sw = new StreamWriter(st1, Encoding.UTF8);

                sw.WriteLine(readValue);

                sw.Flush();

            }

        }

    }

}

