using System;

public class Paperboy
{
    public void CollectPayment(Customer customer, double paymentAmount)
    {
        bool paid = customer.Pay(paymentAmount);

        if (paid)
        {
            Console.WriteLine("Payment received: " + paymentAmount);
        }
        else
        {
            Console.WriteLine("Not enough money. Come back later.");
        }
    }
}
