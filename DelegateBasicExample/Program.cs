namespace DelegateBasicExample;

class Program
{
    delegate void LogDel(string text);
    static void Main(string[] args)
    {
        LogDel logDel = new LogDel(LogTextToScreen);
        logDel.Invoke("text");
        logDel("tttexxxt");
    }

    static void LogTextToScreen(  string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");
    }
}

