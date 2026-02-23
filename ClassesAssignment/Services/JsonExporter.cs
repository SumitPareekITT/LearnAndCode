using System.Collections.Generic;
using System.IO;
using ClassesAssignment.Models;
using System.Text.Json;

namespace ClassesAssignment.Services
{
    public class JsonExporter
    {
        public void Export(List<DataRecord> records, string path)
        {
            var json = JsonSerializer.Serialize(records, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, json);
        }
    }
}
