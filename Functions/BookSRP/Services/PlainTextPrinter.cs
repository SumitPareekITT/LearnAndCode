using BookSRP.Interfaces;

namespace BookSRP.Services;

public class PlainTextPrinter : IPrinter
{
    public void PrintPage(string page)
    {
        Console.WriteLine(page);
    }
}