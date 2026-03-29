using System.Text;
using CustomerSearch.Interfaces;
using CustomerSearch.Models;

namespace CustomerSearch.Services;

public class CsvExportService : IExportService
{
    private const string Header = "CustomerId,CompanyName,ContactName,Country";

    public string Export(List<Customer> customers)
    {
        var stringBuilder = new StringBuilder();
        
        stringBuilder.AppendLine(Header);

        foreach (var customer in customers)
        {
            stringBuilder.AppendLine($"{customer.CustomerId},{customer.CompanyName},{customer.ContactName},{customer.Country}");
        }

        return stringBuilder.ToString();
    }
}