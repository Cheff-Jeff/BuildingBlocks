using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RuleContainer
    {
        IRuleContainer irulecontainer;

        public RuleContainer(IRuleContainer dal)
        {
            irulecontainer = dal;
        }

        public bool AddRule(Rule rule)
        {
            return irulecontainer.AddRule(rule.TODTO());
        }
        public Rule GetRule(int id)
        {
            return new Rule(irulecontainer.GetRule(id));
        }
        public Rule GetRuleFromSystem(int systemId)
        {
            return new Rule(irulecontainer.GetRuleFromSystem(systemId));
        }
        public List<Rule> GetRules()
        {
            List<Rule> rules = new List<Rule>();
            foreach (RuleDTO ruleDTO in irulecontainer.GetRules())
            {
                rules.Add(new Rule(ruleDTO));
            }
            return rules;
        }
        public bool RemoveRule(Rule rule)
        {
            return irulecontainer.RemoveRule(rule.TODTO());
        }
    }
}
