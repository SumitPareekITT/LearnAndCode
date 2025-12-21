using BookSRP.Interfaces;

namespace BookSRP.Services;

public class HtmlPrinter : IPrinter
{
    public void PrintPage(string page)
    {
        Console.WriteLine($"<div class=\"single-page\">{page}</div>");
    }
}