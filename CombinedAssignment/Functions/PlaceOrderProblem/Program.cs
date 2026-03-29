using System;

class PlaceOrderRefactor
{
    static void Main()
    {
        PlaceOrder(5, 1000);
    }

    static void PlaceOrder(int orderId, decimal orderAmount)
    {
        if (!ValidateOrder(orderId))
        {
            ShowInvalidOrderMessage();
            return;
        }

        decimal finalAmount = CalculateFinalAmount(orderAmount);
        SaveOrder(orderId, finalAmount);
        ShowOrderSuccess();
    }

    static bool ValidateOrder(int orderId)
    {
        return orderId > 0;
    }

    static decimal CalculateFinalAmount(decimal orderAmount)
    {
        decimal discount = CalculateDiscount(orderAmount);
        decimal tax = CalculateTax(orderAmount);
        return orderAmount + tax - discount;
    }

    static decimal CalculateDiscount(decimal amount)
    {
        return amount * 0.10m;
    }

    static decimal CalculateTax(decimal amount)
    {
        return amount * 0.18m;
    }

    static void ShowInvalidOrderMessage()
    {
        Console.WriteLine("Order cannot be empty");
    }

    static void SaveOrder(int orderId, decimal amount)
    {
        Console.WriteLine($"Order {orderId} saved in database with final amount {amount}");
    }

    static void ShowOrderSuccess()
    {
        Console.WriteLine("Order placed successfully");
    }
}
