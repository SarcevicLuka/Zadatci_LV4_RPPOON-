using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_zadatak
{
    class Adapter:IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            int rows = dataset.GetData().Count;
            double[][] convertedData = new double[rows][];
            for(int i = 0; i < rows; i++)
            {
                int columns = dataset.GetData()[i].Count;
                convertedData[i] = new double[columns];
                for(int j = 0; j < columns; j++)
                {
                    convertedData[i][j] = dataset.GetData()[i][j];
                }
            }
            return convertedData;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
