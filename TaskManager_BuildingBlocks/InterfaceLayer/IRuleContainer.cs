﻿using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IRuleContainer
    {
        public bool AddRule(RuleDTO ruleDTO);
        public RuleDTO GetRule(int id, string name);
        public RuleDTO GetRuleFromSystem(int systemId);
        public List<RuleDTO> GetRules();
        public bool RemoveRule(RuleDTO ruleDTO);
    }
}
