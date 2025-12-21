using CustomerSearch.Interfaces;
using CustomerSearch.Repositories;
using CustomerSearch.Services;


ICustomerRepository customerRepository = new CustomerRepository();
ICustomerSearchService searchService = new CustomerSearchService(customerRepository);
IExportService exportService = new CsvExportService();

Console.WriteLine("CUSTOMER SEARCH APPLICATION");
Console.WriteLine("===========================");
Console.WriteLine();

Console.WriteLine("1. Search by Country: 'Germany'");
Console.WriteLine("--------------------------------");
var germanCustomers = searchService.SearchByCountry("Germany");
DisplayCustomers(germanCustomers);

Console.WriteLine("2. Search by Company Name: 'Bon'");
Console.WriteLine("---------------------------------");
var companyResults = searchService.SearchByCompanyName("Bon");
DisplayCustomers(companyResults);

Console.WriteLine("3. Search by Contact: 'Maria'");
Console.WriteLine("------------------------------");
var contactResults = searchService.SearchByContact("Maria");
DisplayCustomers(contactResults);

Console.WriteLine("4. Export German Customers to CSV:");
Console.WriteLine("-----------------------------------");
var csvOutput = exportService.Export(germanCustomers);
Console.WriteLine(csvOutput);

void DisplayCustomers(List<CustomerSearch.Models.Customer> customers)
{
    if (customers.Count == 0)
    {
        Console.WriteLine("  No customers found.");
    }
    else
    {
        foreach (var customer in customers)
        {
            Console.WriteLine($"  {customer.CustomerId} | {customer.CompanyName} | {customer.ContactName} | {customer.Country}");
        }
    }
    Console.WriteLine();
}