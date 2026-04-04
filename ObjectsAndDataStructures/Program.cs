using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John", "Doe", 50.0);
        Paperboy paperboy = new Paperboy();

        paperboy.CollectPayment(customer, 20.0);
        paperboy.CollectPayment(customer, 40.0);

        Console.ReadLine();
    }
}
