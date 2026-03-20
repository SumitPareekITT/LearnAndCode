using System.Collections.Generic;
using ClassesAssignment.Models;

namespace ClassesAssignment.Services
{
    public class DataTransformer
    {
        public void Transform(List<DataRecord> records)
        {
            foreach (var r in records)
            {
                r.Name = r.Name.ToUpper();
                r.DoubledValue = r.Value * 2;
                r.SquaredValue = r.Value * r.Value;
            }
        }
    }
}
