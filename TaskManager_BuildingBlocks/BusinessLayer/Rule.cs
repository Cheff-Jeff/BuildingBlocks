using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Rule
    {
        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public int SystemId { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string NotifyEmail { get; set; }

        IRule IRule;

        public Rule()
        {

        }

        public Rule(int id, string rulename,int systemid, int min, int max, string notifyemail)
        {
            RuleId = id;
            RuleName = rulename;
            SystemId = systemid;
            Min = min;
            Max = max;
            NotifyEmail = notifyemail;
        }


        public Rule(IRule dal)
        {
            IRule = dal;
        }

        public Rule(RuleDTO dto)
        {
            this.RuleId = dto.RuleId;
            this.RuleName = dto.RuleName;
            this.SystemId = dto.SystemId;
            this.Min = dto.Min;
            this.Max = dto.Max;
            this.NotifyEmail = dto.NotifyEmail;
        }

        public RuleDTO TODTO()
        {
            return new RuleDTO(RuleId, RuleName, SystemId, Min, Max, NotifyEmail);
        }


        IRule irule;

        public bool UpdateRule(IRule dal)
        {
            irule = dal;
            return irule.UpdateRule(TODTO());
        }
    }
}
