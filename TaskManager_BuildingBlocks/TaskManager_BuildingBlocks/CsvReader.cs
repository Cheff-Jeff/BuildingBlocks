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
        public List<int> GetData()
        {
            using (var reader = new StreamReader(@"\Properties\Data_Numbers_Outsource.csv"))
            //using (var reader = new StreamReader(@"..\..\..\..\Solitaire\Properties\solitaire1.csv"))


            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[1]);
                    listB.Add(values[2]);
                    listC.Add(values[3]);
                }

                for (int cardcount = 0; cardcount < 52; cardcount++)
                {
                    Card card = new Card(listA[cardcount], listB[cardcount], Convert.ToInt32(listC[cardcount]), false);
                    this.cards.Add(card);
                }

            }
            return cards;
        }
    }
}
