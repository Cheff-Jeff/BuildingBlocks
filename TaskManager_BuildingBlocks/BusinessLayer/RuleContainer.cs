using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RuleContainer
    {
        IRuleContainer IRules;

        public RuleContainer(IRuleContainer rule)
        {
            IRules = rule;
        }
        public List<Rule> GetAllRules()
        {
            var rules = new List<Rule>();
            IRules.GetAllRules().ForEach(r => rules.Add(new Rule(r)));
            return rules;
        }
        public List<Rule> GetAllRulesFromServer(int serverId)
        {
            var rules = new List<Rule>();
            IRules.GetAllRulesFromServer(serverId).ForEach(r => rules.Add(new Rule(r)));
            return rules;
        }
        public Rule GetRuleTypeFromServer(int serverId, string typeName)
        {
            return new Rule(IRules.GetRuleTypeFromServer(serverId, typeName));
        }
    }
}
