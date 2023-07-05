interface ILogger
{
    void WriteLog (string message);
}
class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()} : {message}");
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        ConsoleLogger logger = new ConsoleLogger();
        logger.WriteLog("장애 이벤트 발생");
    }
}
