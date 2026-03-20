using System;
using System.Collections.Generic;

using ClassesAssignment.Models;

namespace ClassesAssignment.Services
{
    public class DataParser
    {
        public List<DataRecord> Parse(List<string> lines)
        {
            var records = new List<DataRecord>();

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length >= 4 &&
                    double.TryParse(parts[2], out double value) &&
                    DateTime.TryParse(parts[3], out DateTime date))
                {
                    records.Add(new DataRecord
                    {
                        Id = parts[0],
                        Name = parts[1],
                        Value = value,
                        Date = date
                    });
                }
            }

            return records;
        }
    }
}
