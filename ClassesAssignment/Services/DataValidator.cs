using System.Collections.Generic;
using System.Linq;
using ClassesAssignment.Models;

namespace ClassesAssignment.Services
{
    public class DataValidator
    {
        public List<DataRecord> Validate(List<DataRecord> records)
        {
            return records
                .Where(r => !string.IsNullOrWhiteSpace(r.Id)
                         && !string.IsNullOrWhiteSpace(r.Name))
                .ToList();
        }
    }
}
