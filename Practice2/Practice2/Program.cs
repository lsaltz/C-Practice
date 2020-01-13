using Microsoft.ML;
using System;
using System.IO;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MLContext();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string dataFilePath = Path.Combine(path, "pulsar_stars.csv");

            IDataView train = context.Data.LoadFromTextFile<StarsData>(path: dataFilePath, hasHeader: true, separatorChar: ',');

            var pipeline = context.Transforms.Concatenate("Features",new[] { "Mean_of_the_integrated_profile","Standard_deviation_of_the_integrated_profile","Excess_kurtosis_of_the_integrated_profile","Skewness_of_the_integrated_profile","Mean_of_the_DMSNR_curve","Standard_deviation_of_the_DMSNR_curve","Excess_kurtosis_of_the_DMSNR_curve","Skewness_of_the_DMSNR_curve" }).Append(context.Regression.Trainers.LbfgsPoissonRegression());

            var model = pipeline.Fit(train);

            var predictions = model.Transform(train);

            var metrics = context.Regression.Evaluate(predictions);

            Console.WriteLine($"R^2 - {metrics.RSquared}");

            var data = new StarsData
            {
                Standard_deviation_of_the_integrated_profile = 55.68378214f,
                Mean_of_the_integrated_profile = 140.5625f
            };
            var predictionFunc = context.Model.CreatePredictionEngine<StarsData, Prediction>(model);

            var prediction = predictionFunc.Predict(data);

            Console.WriteLine("Data predicting from: " + data);

            Console.WriteLine($"Is it a Pulsar Star? - {prediction.PredictionData}");
            if(prediction.PredictionData == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
