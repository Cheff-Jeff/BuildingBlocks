using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer.DTO
{
    public class MetricDTO
    {
        public int MetricId;
        public string Name;
        public int SystemId;
        public int Value;
        public DateTime Date;

        public MetricDTO(int id, string name, int systemId, int value, DateTime date)
        {
            MetricId = id;
            Name = name;
            SystemId = systemId;
            Value = value;
            Date = date;
        }
    }
}
