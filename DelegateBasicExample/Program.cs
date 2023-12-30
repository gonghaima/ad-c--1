namespace DelegateBasicExample;

class Program
{
    delegate void LogDel(string text);
    static void Main(string[] args)
    {
        //LogDel logDel = new LogDel(LogTextToScreen);
        Log log = new Log();
        LogDel LogTextToScreenDel, LogTextToFileDel;

        LogTextToScreenDel = new LogDel(log.LogTextToScreen);
        LogTextToFileDel = new LogDel(log.LogTextToFile);

        LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;

        Console.WriteLine("Please enter your name");
        var name = Console.ReadLine();

        //logDel.Invoke("text");
        multiLogDel(name);
        Console.ReadKey();
    }

    //static void LogTextToScreen(  string text)
    //{
    //    Console.WriteLine($"{DateTime.Now}: {text}");
    //}

    //static void LogTextToFile(string text)
    //{
    //    using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
    //    {
    //        sw.WriteLine($"{DateTime.Now}: {text}");
    //    }
    //}
}

public class Log
{
    public void LogTextToScreen(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");

    }

    public void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}

