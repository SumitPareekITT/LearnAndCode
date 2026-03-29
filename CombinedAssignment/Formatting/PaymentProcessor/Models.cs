using System;

public class PaymentRequest
{
    public string CustomerId { get; set; }
    public decimal Amount { get; set; }
}

public class PaymentRecord
{
    public string CustomerId { get; }
    public decimal Amount { get; }
    public DateTime Timestamp { get; }

    public PaymentRecord(string customerId, decimal amount, DateTime timestamp)
    {
        CustomerId = customerId;
        Amount = amount;
        Timestamp = timestamp;
    }
}

public class PaymentResult
{
    public bool Success { get; }
    public string Message { get; }
    public string TransactionId { get; }

    public PaymentResult(bool success, string message, string transactionId)
    {
        Success = success;
        Message = message;
        TransactionId = transactionId;
    }
}

public class PaymentException : Exception
{
    public PaymentException(string msg) : base(msg) { }
}
