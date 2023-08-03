using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TcpServerPicture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인터넷 주소 포트 만들기
            IPAddress localAddr = IPAddress.Parse("192.168.43.192");
            int port = 13001;

            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Console.WriteLine("서버 시작...");

            using (TcpClient client = server.AcceptTcpClient()) //block I/O
            {
                Console.WriteLine("연결 성공!!");
                //사진전송

                using (NetworkStream stream = client.GetStream()) //write 대상 객체
                {                   
                    byte[] data = File.ReadAllBytes(@"./sonny02.jpg");
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("전송 완료!!");
                }              
            }
            server.Stop();
        }
    }
}
