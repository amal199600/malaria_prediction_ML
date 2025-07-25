﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML;

namespace MalariaPredication
{
    public partial class MLModel1
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"Fever", @"Fever"),new InputOutputColumnPair(@"Headache", @"Headache"),new InputOutputColumnPair(@"Fatigue", @"Fatigue"),new InputOutputColumnPair(@"MusclePain", @"MusclePain"),new InputOutputColumnPair(@"Nausea_Vomiting", @"Nausea_Vomiting"),new InputOutputColumnPair(@"Diarrhea", @"Diarrhea"),new InputOutputColumnPair(@"Seizures", @"Seizures")}, outputKind: OneHotEncodingEstimator.OutputKind.Indicator)      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(@"Id", @"Id"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"City",outputColumnName:@"City"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Fever",@"Headache",@"Fatigue",@"MusclePain",@"Nausea_Vomiting",@"Diarrhea",@"Seizures",@"Id",@"City"}))      
                                    .Append(mlContext.Regression.Trainers.FastForest(new FastForestRegressionTrainer.Options(){NumberOfTrees=4,NumberOfLeaves=4,FeatureFraction=1F,LabelColumnName=@"TestResult",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}
