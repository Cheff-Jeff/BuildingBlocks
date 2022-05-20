using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IRuleContainer
    {
        public List<RuleDTO> GetAllRules();
        public List<RuleDTO> GetAllRulesFromServer(int serverId);
        public RuleDTO GetRuleTypeFromServer(int serverId, string typeName);
    }
}
