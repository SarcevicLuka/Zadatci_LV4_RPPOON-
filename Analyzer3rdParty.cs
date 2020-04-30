using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_zadatak
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            Console.WriteLine(rowCount);
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int colCount = data[1].Length;
            double sum = 0;
            double[] results = new double[colCount];
            for(int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    sum += data[j][i];
                }
                results[i] = sum/(float)rowCount;
                sum = 0;
            }
            return results;
        }
    }
}
