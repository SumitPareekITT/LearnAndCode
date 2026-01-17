using System.Collections.Generic;

public class Order
{
    public string CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; }
    public List<string> Items { get; set; } = new();
    public OrderStatus Status { get; set; }
    public string TransactionId { get; set; }
}

public enum OrderStatus
{
    Pending,
    Paid,
    Cancelled
}

public class PaymentResult
{
    public bool IsSuccessful { get; set; }
    public string TransactionId { get; set; }
    public string ErrorMessage { get; set; }
}

public class OrderResult
{
    public bool Success { get; set; }
    public string Message { get; set; }

    public static OrderResult SuccessResult(string tx) => new() { Success = true, Message = tx };
    public static OrderResult Failed(string msg) => new() { Success = false, Message = msg };
    public static OrderResult Invalid(string msg) => new() { Success = false, Message = msg };
}
