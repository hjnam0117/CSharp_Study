using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTcpServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 인터넷 주소 만들기, 서버 주소 만들기, 포트 만들기
            IPAddress localAddr = IPAddress.Parse("192.168.43.192");
            int port = 13000;
            //2. 서버 객체만들기
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Console.WriteLine("서버 시작...");

            using(TcpClient client = server.AcceptTcpClient()) //block I/O
            {
                Console.WriteLine("연결 성공!!");

                //클라이언트에 메세지를 보내고 싶어~
                //3. 소켓에 write할 준비
                using(NetworkStream stream = client.GetStream()) //write 대상 객체
                {
                    string response = "안녕하세요. 클라이언트님";
                    byte[] date = Encoding.UTF8.GetBytes(response);

                    //데이터 전송(write)
                    stream.Write(date, 0, date.Length);
                    Console.WriteLine($"전송한 메세지 : {response}");
                }
            }   
        }
    }
}
