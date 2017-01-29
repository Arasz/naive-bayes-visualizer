using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Accord.MachineLearning.Bayes;
using Accord.Math;
using Accord.Statistics.Filters;

namespace NaiveBayesVisualization.Data
{
    public class ExperimentData
    {
        private readonly CsvDataReader _dataReader;
        private int _loadedDataSize;

        public DataTable TrainData { get; }
        public Codification Codebook { get; private set; }
        public List<string> ColumnLabels { get; }
        private NaiveBayes _naiveBayes;
        public double[,][] Distributions => _naiveBayes.Distributions;
        public double[] Priors => _naiveBayes.Priors;

        private string[] _lastLine;


        public ExperimentData(CsvDataReader dataReader, int loadedDataSize = int.MaxValue)
        {
            _dataReader = dataReader;
            _loadedDataSize = loadedDataSize;
            ColumnLabels = new List<string>();
            TrainData = new DataTable("TrainData");
            Load();
        }

        private void Load()
        {
            var dataLines = _dataReader.ReadLines();

            CalculateDataSetSizes(dataLines);

            CreateColumns();

            foreach (var dataLine in dataLines.Take(_loadedDataSize))
                InsertRowToTable(dataLine, TrainData);

            Codebook = new Codification(TrainData, ColumnLabels.ToArray());
            var symbols = Codebook.Apply(TrainData);
            var inputs = symbols.ToArray<int>(ColumnLabels.GetRange(0, ColumnLabels.Count - 1).ToArray());
            var outputs = symbols.ToArray<int>(ColumnLabels[ColumnLabels.Count - 1]);

            // Create a new Naive Bayes learning
            var learner = new NaiveBayesLearning();

            // Learn a Naive Bayes model from the examples
            _naiveBayes = learner.Learn(inputs, outputs);
            
        }

        public double[] Predict(string[] testData)
        {
            return _naiveBayes.Probabilities(TranslateDecisions(testData));
        }

        private void CalculateDataSetSizes(IList<string[]> dataLines)
        {
            if (dataLines.Count < _loadedDataSize)
                _loadedDataSize = dataLines.Count;
        }

        private void CreateColumns()
        {
            foreach (var columnName in _dataReader.Headers)
            {
                TrainData.Columns.Add(columnName);
                ColumnLabels.Add(columnName);
            }
        }

        private void InsertRowToTable(string[] dataLine, DataTable dataTable)
        {
            dataTable.Rows.Add
            (
                dataLine
            );
            _lastLine = dataLine;
        }

        public int[] TranslateDecisions(string[] decisions)
        {
            return Codebook.Translate(decisions);
        }

        public string[] GenerateTestDecisions()
        {
            return _lastLine;
        }
    }
}