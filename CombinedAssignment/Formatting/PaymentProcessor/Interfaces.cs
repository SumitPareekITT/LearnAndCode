using System;

public interface ILogger
{
    void Log(string message);
}

public interface INotificationService
{
    void Send(string customerId, string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}

public class ConsoleNotificationService : INotificationService
{
    public void Send(string customerId, string message)
    {
        Console.WriteLine($"Notification sent to {customerId}: {message}");
    }
}
