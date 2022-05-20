using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class RuleContainer
    {
        IRuleContainer IRules;

        public RuleContainer(IRuleContainer rule)
        {
            IRules = rule;
        }
    }
}
