using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_zadatak
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
