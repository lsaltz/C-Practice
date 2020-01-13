using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class StarsData
    {
        [ColumnName("Mean_of_the_integrated_profile"), LoadColumn(0)]
        public float Mean_of_the_integrated_profile { get; set; }

        [ColumnName("Standard_deviation_of_the_integrated_profile"), LoadColumn(1)]
        public float Standard_deviation_of_the_integrated_profile { get; set; }

        [ColumnName("Excess_kurtosis_of_the_integrated_profile"), LoadColumn(2)]
        public float Excess_kurtosis_of_the_integrated_profile { get; set; }

        [ColumnName("Skewness_of_the_integrated_profile"), LoadColumn(3)]
        public float Skewness_of_the_integrated_profile { get; set; }

        [ColumnName("Mean_of_the_DMSNR_curve"), LoadColumn(4)]
        public float Mean_of_the_DMSNR_curve { get; set; }

        [ColumnName("Standard_deviation_of_the_DMSNR_curve"), LoadColumn(5)]
        public float Standard_deviation_of_the_DMSNR_curve { get; set; }

        [ColumnName("Excess_kurtosis_of_the_DMSNR_curve"), LoadColumn(6)]
        public float Excess_kurtosis_of_the_DMSNR_curve { get; set; }

        [ColumnName("Skewness_of_the_DMSNR_curve"), LoadColumn(7)]
        public float Skewness_of_the_DMSNR_curve { get; set; }

        [ColumnName("Label"), LoadColumn(8)]
        public float target_class { get; set; }

      
    }
}
