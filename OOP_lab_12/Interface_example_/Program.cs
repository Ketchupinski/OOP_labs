using System;

namespace Interface_example_
{
    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from DB";
        }
    }

    class ApiDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from API";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from file";
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var processor = new ConsoleDataProcessor();
            
            processor.ProcessData(new ApiDataProvider());
            processor.ProcessData(new DbDataProvider());
            processor.ProcessData(new FileDataProvider());
        }
    }
}