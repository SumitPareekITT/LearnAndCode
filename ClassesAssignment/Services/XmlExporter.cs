using System.Collections.Generic;
using System.IO;
using ClassesAssignment.Models;
using System.Xml.Serialization;

namespace ClassesAssignment.Services
{
    public class XmlExporter
    {
        public void Export(List<DataRecord> records, string path)
        {
            var serializer = new XmlSerializer(typeof(List<DataRecord>));
            using var writer = new StreamWriter(path);
            serializer.Serialize(writer, records);
        }
    }
}
