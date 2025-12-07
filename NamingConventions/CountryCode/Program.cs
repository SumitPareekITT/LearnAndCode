using System;
using System.Collections.Generic;

namespace AdjacentCountriesApp
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Adjacent Countries Checker";

            Dictionary<string, List<string>> borderMap = LoadBorderData();

            Console.WriteLine("---- Adjacent Countries Search ----\n");
            Console.WriteLine("Enter a 2-letter ISO country code (Example: IN, US, NZ).");
            Console.WriteLine("Type EXIT to close the program.\n");

            while (true)
            {
                Console.Write("Country Code: ");
                string code = Console.ReadLine().Trim().ToUpper();

                if (code == "EXIT")
                {
                    Console.WriteLine("\nApplication closed.");
                    break;
                }

                if (string.IsNullOrWhiteSpace(code) || code.Length != 2)
                {
                    Console.WriteLine("Error: Country code must contain 2 letters.\n");
                    continue;
                }

                if (borderMap.TryGetValue(code, out List<string> neighbors))
                {
                    Console.WriteLine($"\nAdjacent Countries for {code}:");

                    foreach (var country in neighbors)
                    {
                        Console.WriteLine(" - " + country);
                    }

                    Console.WriteLine();  
                }
                else
                {
                    Console.WriteLine("No border details found.\n");
                }
            }
        }



        static Dictionary<string, List<string>> LoadBorderData()
        {
            return new Dictionary<string, List<string>>()
            {
                { "IN", new List<string> { "Pakistan", "China", "Nepal", "Bhutan", "Bangladesh", "Myanmar" } },
                { "US", new List<string> { "Canada", "Mexico" } },
                { "NZ", new List<string> { "None – New Zealand is an island nation" } },
                { "CA", new List<string> { "United States" } },
                { "CN", new List<string> 
                    { 
                        "India", "Nepal", "Bhutan", "Myanmar", "Russia", 
                        "Mongolia", "Pakistan", "Afghanistan", "North Korea", 
                        "Kazakhstan", "Kyrgyzstan", "Laos", "Vietnam" 
                    } 
                },
                { "AU", new List<string> { "None – Australia has no land borders" } }
            };
        }
    }
}