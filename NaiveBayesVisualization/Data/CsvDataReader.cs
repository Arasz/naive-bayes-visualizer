using System.Collections.Generic;
using Accord.IO;

namespace NaiveBayesVisualization.Data
{
    public class CsvDataReader
    {
        private readonly string _dataPath;
        private readonly bool _hasHeaders;

        public CsvDataReader(string dataPath, bool hasHeaders = true)
        {
            _dataPath = dataPath;
            _hasHeaders = hasHeaders;
        }

        public string[] Headers { get; private set; }

        private CsvReader NewReader => new CsvReader(_dataPath, _hasHeaders);

        public IList<string[]> ReadLines()
        {
            using (var reader = NewReader)
            {
                Headers = reader.GetFieldHeaders();
                return reader.ReadToEnd();
            }
        }
    }
}