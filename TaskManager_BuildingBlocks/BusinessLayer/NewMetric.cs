using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NewMetric
    {
        public string Name { get; set; }
        public int SystemId { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }

        public NewMetric(string name, int systemId, int value, DateTime date)
        {
            Name = name;
            SystemId = systemId;
            Value = value;
            Date = date;
        }
    }
}
