namespace DelegateBasicExample;

class Program
{
    delegate void LogDel(string text, DateTime dateTime);
    static void Main(string[] args)
    {
        LogDel logDel = new LogDel(LogTextToScreen);
        //logDel.Invoke("text");
        Console.WriteLine("Please enter your name");
        var name = Console.ReadLine();

        logDel(name, DateTime.Now);
        Console.ReadKey();
    }

    static void LogTextToScreen(  string text, DateTime dateTime)
    {
        Console.WriteLine($"{dateTime}: {text}");
    }
}

