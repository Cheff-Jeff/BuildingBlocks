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
        public string RuleName;
        public int SystemId;
        public int Min;
        public int Max;
        public string NotifyEmail;

        public RuleDTO(int id, string rulename, int systemid, int min, int max, string notifyemail)
        {
            RuleId = id;
            RuleName = rulename;
            SystemId = systemid;
            Min = min;
            Max = max;
            NotifyEmail = notifyemail;
        }

        public RuleDTO() { }
    }
}
