using System.Collections.Generic;
using System.IO;
using ClassesAssignment.Models;

namespace ClassesAssignment.Services
{
    public class CsvExporter
    {
        public void Export(List<DataRecord> records, string path)
        {
            var lines = new List<string>
            {
                "ID,NAME,VALUE,DATE,DOUBLED,SQUARED"
            };

            foreach (var r in records)
            {
                lines.Add($"{r.Id},{r.Name},{r.Value},{r.Date:yyyy-MM-dd},{r.DoubledValue},{r.SquaredValue}");
            }

            File.WriteAllLines(path, lines);
        }
    }
}
