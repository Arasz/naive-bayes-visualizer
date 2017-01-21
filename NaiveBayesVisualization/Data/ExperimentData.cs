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
        public NaiveBayes NaiveBayes { get; private set; }


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
            var inputs = symbols.ToArray<int>(ColumnLabels.GetRange(0, ColumnLabels.Count-1).ToArray());
            var outputs = symbols.ToArray<int>(ColumnLabels[ColumnLabels.Count-1]);

            // Create a new Naive Bayes learning
            var learner = new NaiveBayesLearning();

            // Learn a Naive Bayes model from the examples
            NaiveBayes = learner.Learn(inputs, outputs);
        }

        private void Predict(NaiveBayes nb, string[] testData)
        {
            // Consider we would like to know whether one should play tennis at a
            // sunny, cool, humid and windy day. Let us first encode this instance
            var instance = Codebook.Translate(testData);

            // Let us obtain the numeric output that represents the answer
            var c = nb.Decide(instance); // answer will be 0

            // Now let us convert the numeric output to an actual "Yes" or "No" answer
            var result = Codebook.Translate(ColumnLabels[ColumnLabels.Count - 1], c); // answer will be "No"

            // We can also extract the probabilities for each possible answer
            var probs = nb.Probabilities(instance); // { 0.795, 0.205 }
            var priors = nb.Priors;
            var distributions = nb.Distributions;
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

        private static void InsertRowToTable(string[] dataLine, DataTable dataTable) => dataTable.Rows.Add(dataLine);
    }
}