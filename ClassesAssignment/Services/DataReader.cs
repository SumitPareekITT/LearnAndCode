using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassesAssignment.Services
{
    public class DataReader
    {
        public List<string> Read(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}
