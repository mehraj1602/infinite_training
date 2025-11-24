using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_21stnov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter;

            Console.WriteLine("Exporting CSV");
            exporter = new CsvExporter();
            exporter.Export();

            Console.WriteLine("Exporting JSON");
            exporter = new JsonExporter();
            exporter.Export();

            Console.WriteLine("Exporting XML");
            exporter = new XmlExporter();
            exporter.Export();

        }
    }
}
