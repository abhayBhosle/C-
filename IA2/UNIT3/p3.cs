using System;

public interface ILogger
{
    void LogMessage(string message);
}

public class ConsoleLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

class p3
{
    static void Main(string[] args)
    {
        ConsoleLogger cc = new ConsoleLogger();
        cc.LogMessage("This is an implicit invocation example. ");
        ((ILogger)cc).LogMessage("This is an explicit invocation example. ");
    }
}