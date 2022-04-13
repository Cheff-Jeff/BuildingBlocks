using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_BuildingBlocks
{
    internal class CsvReader
    {
        //gets data from a csv file and returns it in a list.
        public List<double[]> GetData()
        {
            List<double[]> statslist = new List<double[]>();

            using (var reader = new StreamReader(@"\Properties\Data_Numbers_Outsource.csv"))
            {
                List<double> listA = new List<double>();
                List<double> listB = new List<double>();
                List<double> listC = new List<double>();
                List<double> listD = new List<double>();
                List<double> listE = new List<double>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(Convert.ToDouble(values[1]));
                    listB.Add(Convert.ToDouble(values[2]));
                    listC.Add(Convert.ToDouble(values[3]));
                    listD.Add(Convert.ToDouble(values[4]));
                    listE.Add(Convert.ToDouble(values[5]));
                }
               
                for (int statcount = 0; statcount < 52; statcount++)
                {
                    double[] stat = { listA[statcount], listB[statcount], listC[statcount], listD[statcount], listE[statcount] };
                    statslist.Add(stat);
                }
            }
            return statslist;
        }
    }
}
