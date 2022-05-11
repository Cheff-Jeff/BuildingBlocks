using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CsvReader
    {
        //gets data from a csv file and returns it in a list.
        public PcData GetData(int id)
        {
            PcData data = new PcData();

            using (var reader = new StreamReader("../../../../BusinessLogicLayer/CSV/Datasheet.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if(id == Convert.ToInt32(values[0]))
                    {
                        data.id.Add(Convert.ToInt32(values[0]));
                        data.CPU.Add(Convert.ToInt32(values[1]));
                        data.GPU.Add(Convert.ToInt32(values[2]));
                        data.Ram.Add(Convert.ToInt32(values[3]));
                        data.Disk.Add(Convert.ToInt32(values[4]));
                        data.Network.Add(Convert.ToInt32(values[5]));
                    }
                    

                }

                //for (int statcount = 0; statcount < listA.Count; statcount++)
                //{
                //    PcData stat = new PcData( listA[statcount], listB[statcount], listC[statcount], listD[statcount], listE[statcount], listF[statcount] );
                //    statslist.Add(stat);
                //}
            }
            return data;
        }
    }
}
