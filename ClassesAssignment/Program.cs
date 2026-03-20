using System;
using System.Collections.Generic;
using System.IO;
using ClassesAssignment.Models;
using ClassesAssignment.Services;

namespace ClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.csv";

            GenerateSampleData(inputFile);

            var reader = new DataReader();
            var parser = new DataParser();
            var validator = new DataValidator();
            var transformer = new DataTransformer();
            var stats = new StatisticsCalculator();
            var csvExporter = new CsvExporter();
            var jsonExporter = new JsonExporter();
            var xmlExporter = new XmlExporter();

            var lines = reader.Read(inputFile);
            var records = parser.Parse(lines);
            records = validator.Validate(records);
            transformer.Transform(records);

            stats.PrintStats(records);

            csvExporter.Export(records, "output.csv");
            jsonExporter.Export(records, "output.json");
            xmlExporter.Export(records, "output.xml");

            Console.WriteLine("\nProcessing Complete.");
        }

        static void GenerateSampleData(string path)
        {
            var random = new Random();
            var lines = new List<string>();

            for (int i = 1; i <= 20; i++)
            {
                string id = $"ID{i:D3}";
                string name = $"Item{i}";
                double value = random.Next(10, 500);
                DateTime date = DateTime.Now.AddDays(-random.Next(0, 365));

                lines.Add($"{id},{name},{value},{date:yyyy-MM-dd}");
            }

            File.WriteAllLines(path, lines);
        }
    }
}
