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
        public int SystemId { get; set; }
        public int MinMax { get; set; }
        public int Limit { get; set; }
        public int Limit2 { get; set; }
        public string NotifyEmail { get; set; }

        IRule IRule;

        public Rule()
        {

        }

        public Rule(IRule dal)
        {
            IRule = dal;
        }

        public Rule(RuleDTO dto)
        {
            this.RuleId = dto.RuleId;
            this.SystemId = dto.SystemId;
            this.MinMax = dto.MinMax;
            this.Limit = dto.Limit;
            this.Limit2 = dto.Limit2;
            this.NotifyEmail = dto.NotifyEmail;
        }
    }
}
