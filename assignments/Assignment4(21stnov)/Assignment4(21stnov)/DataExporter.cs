using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_21stnov_
{
    public abstract class DataExporter
    {
        public void Export()
        {
            Connect();
            var data = FetchData();
            var formattedData = FormatData(data);
            SaveToFile(formattedData);
        }
        protected abstract void Connect();
        protected abstract string FetchData();
        protected abstract string FormatData(string data);
        protected abstract void SaveToFile(string formattedData);
    }

    public class CsvExporter : DataExporter
    {
        protected override void Connect()
        {
            Console.WriteLine("Connecting to CSV Source..");
        }

        protected override string FetchData()
        {
            return "id,name\n1,John";
        }

        protected override string FormatData(string data)
        {
            return data;
        }

        protected override void SaveToFile(string formattedData)
        {
            Console.WriteLine("Saved CSV:\n" + formattedData);
        }
    }

    public class JsonExporter : DataExporter
    {
        protected override void Connect()
        {
            Console.WriteLine("Connecting to JSON Source..");
        }

        protected override string FetchData()
        {
            return "{id:1,name:'John'}";
        }

        protected override string FormatData(string data)
        {
            return data;
        }

        protected override void SaveToFile(string formattedData)
        {
            Console.WriteLine("Saved JSON:\n" + formattedData);
        }
    }

    public class XmlExporter : DataExporter
    {
        protected override void Connect()
        {
            Console.WriteLine("Connecting to XML Source..");
        }

        protected override string FetchData()
        {
            return "<user><id>1</id><name>John</name></user>";
        }

        protected override string FormatData(string data)
        {
            return data;
        }

        protected override void SaveToFile(string formattedData)
        {
            Console.WriteLine("Saved XML:\n" + formattedData);
        }
    }
}

