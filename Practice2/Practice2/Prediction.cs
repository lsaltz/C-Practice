using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Practice2
{
    class Prediction
    {
        [ColumnName("Output")]
        public float PredictionData { get; set; }
    }
}

