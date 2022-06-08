using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RuleModel
    {
        [Key]
        public int RuleId { get; set; }

        [Required]
        public string RuleName { get; set; }
        public int SystemId { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string NotifyEmail { get; set; }

        public RuleModel(int systemid)
        {
            SystemId = systemid;
        }

        public RuleModel() { }

    }
}
