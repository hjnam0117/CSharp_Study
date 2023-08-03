using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalEvent
{
    public delegate void FestivalStartedEventHandler(object sender, EventArgs e);
    public class Festival
    {
        // FestivalStartedEventHandler 타입의 이벤트를 여기에 선언하세요
        public event FestivalStartedEventHandler FestivalStarted;
        public void StartFestival()
        {
            // 이벤트를 여기에서 트리거하세요
            FestivalStarted?.Invoke(this, EventArgs.Empty);
        }
        // 축제 시작 이벤트를 구독하고 "축제가 시작되었습니다!"라는 메시지를 출력하는 메서드를 작성하세요
        public void Announce(object sender, EventArgs e)
        {
            Console.WriteLine("축제가 시작되었습니다!");
        }
        // 축제 시작 이벤트를 구독하고 "음악을 연주합니다!"라는 메시지를 출력하는 메서드를 작성하세요
        public void PlayMusic(object sender, EventArgs e)
        {
            Console.WriteLine("음악을 연주합니다!");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Festival festival = new Festival();
            // 축제 시작 이벤트를 구독하는 메서드들을 호출하세요
            festival.FestivalStarted += festival.Announce;
            festival.FestivalStarted += festival.PlayMusic;
            festival.StartFestival();  // 이 메서드 호출을 통해 이벤트를 트리거하세요
        }
    }
}
