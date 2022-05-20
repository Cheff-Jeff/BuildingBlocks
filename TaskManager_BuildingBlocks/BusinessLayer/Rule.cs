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
        public string Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string NotifyEmail { get; set; }


        public Rule()
        {

        }

        public Rule(RuleDTO dto)
        {
            this.RuleId = dto.RuleId;
            this.SystemId = dto.SystemId;
            this.Name = dto.Name;
            this.Min = dto.Min;
            this.Max = dto.Max;
            this.NotifyEmail = dto.NotifyEmail;
        }
    }
}
