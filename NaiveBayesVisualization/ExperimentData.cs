using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace NaiveBayesVisualization.Data
{
    public class ExperimentData
    {
        private readonly CsvDataReader _dataReader;
        private readonly double _testDataPercent;
        private int _loadedDataSize;
        private Random _randomGenerator;
        private DataTable _testData;
        private int _testDataSize;
        private int _testInsertCounter;
        private DataTable _trainData;

        /// <summary>
        /// Lazy loaded test data 
        /// </summary>
        public DataTable TestData
        {
            get
            {
                if (_testData == null)
                    Load();
                return _testData;
            }
        }

        public DataTable TrainData
        {
            get
            {
                if (_trainData == null)
                    Load();
                return _trainData;
            }
        }

        public ExperimentData(CsvDataReader dataReader, double testDataPercent = 0.3, int loadedDataSize = int.MaxValue)
        {
            _dataReader = dataReader;
            _loadedDataSize = loadedDataSize;
            _testDataPercent = testDataPercent;
            _randomGenerator = new Random();
        }

        public void Load()
        {
            _testData = new DataTable("TestData");

            _trainData = new DataTable("TrainData");

            var dataLines = _dataReader.ReadLines();

            CalculateDataSetSizes(dataLines);

            CreateColumns();

            foreach (var dataLine in dataLines.Take(_loadedDataSize))
                RandomlyInsertData(dataLine);
        }

        private void CalculateDataSetSizes(IList<string[]> dataLines)
        {
            if (dataLines.Count < _loadedDataSize)
                _loadedDataSize = dataLines.Count;

            _testDataSize = (int)(_loadedDataSize * _testDataPercent);
        }

        private void CreateColumns()
        {
            foreach (var columnName in _dataReader.Headers)
            {
                _testData.Columns.Add(columnName);
                _trainData.Columns.Add(columnName);
            }
        }

        private void InsertRowToTable(string[] dataLine, DataTable dataTable)
        {
            var row = dataTable.NewRow();
            row.ItemArray = dataLine;
            dataTable.Rows.Add(row);
        }

        private void RandomlyInsertData(string[] dataLine)
        {
            var randomNumber = _randomGenerator.Next(0, 2);

            if (randomNumber == 0 && _testDataSize >= _testInsertCounter)
            {
                _testInsertCounter++;
                InsertRowToTable(dataLine, _testData);
            }
            else
                InsertRowToTable(dataLine, _trainData);
        }
    }
}