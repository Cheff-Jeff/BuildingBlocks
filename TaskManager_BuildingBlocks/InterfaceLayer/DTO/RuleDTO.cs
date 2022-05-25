using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer.DTO
{
    public class RuleDTO
    {
        public int RuleId;
        public int SystemId;
        public string Name;
        public int Min;
        public int Max;
        public string NotifyEmail;
    }
}
