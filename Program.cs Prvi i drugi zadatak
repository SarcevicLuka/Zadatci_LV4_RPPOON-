using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Dataset dataset = new Dataset("D:\\Users\\Korisnik\\Desktop\\CSV datoteka double.txt");
            Analyzer3rdParty analizer3rdParty = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analizer3rdParty);
            double[] rows = adapter.CalculateAveragePerRow(dataset);
            double[] columns = adapter.CalculateAveragePerColumn(dataset);

            for (int i = 0;i< rows.Length; i++){
                Console.WriteLine("Average of " + (i+1) + ". row is:" + rows[i]);
            }
            for (int i = 0; i < columns.Length; i++)
            {
                Console.WriteLine("Average of " + (i+1) + ". column is:" + columns[i]);
            }
        }
    }
}
