using System;

class Program
{
    static void Main()
    {
        var logger = new ConsoleLogger();
        var notifier = new ConsoleNotificationService();

        var processor = new Payment.Processing.PaymentProcessor(logger, notifier);

        var request = new PaymentRequest
        {
            CustomerId = "SUMIT123",
            Amount = 1000m
        };

        var result = processor.Process(request);

        Console.WriteLine($"Result: {result.Message}");
    }
}
