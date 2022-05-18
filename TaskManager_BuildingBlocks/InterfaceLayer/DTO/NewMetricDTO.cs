using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer.DTO
{
    public class NewMetricDTO
    {
        public string Name;
        public int SystemId;
        public int Value;
        public DateTime Date;
        public NewMetricDTO(string name, int systemId, int value, DateTime date)
        {
            Name = name;
            SystemId = systemId;
            Value = value;
            Date = date;
        }
    }
}
