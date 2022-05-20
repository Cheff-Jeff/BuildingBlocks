using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class RuleDAL : SqlConnect, IRule, IRuleContainer
    {
        public List<RuleDTO> GetAllRules()
        {
            OpenConnect();

            List<RuleDTO> rules = new List<RuleDTO>();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Rules";

            using SqlDataReader RulesReader = cmd.ExecuteReader();

            while (RulesReader.Read())
            {
                rules.Add(new RuleDTO()
                {
                    RuleId = (int)RulesReader["Id"],
                    SystemId = (int)RulesReader["SystemId"],
                    Min = (int)RulesReader["Min"],
                    Max = (int)RulesReader["Max"],
                    Name = (string)RulesReader["Name"],
                    NotifyEmail = (string)RulesReader["NotifyEmail"]
                });
            }

            CloseConnect();
            return rules;
        }

        public List<RuleDTO> GetAllRulesFromServer(int serverId)
        {
            OpenConnect();

            List<RuleDTO> rules = new List<RuleDTO>();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Rules WHERE SystemId = @systemId";
            cmd.Parameters.AddWithValue("@systemId", serverId);

            using SqlDataReader RulesReader = cmd.ExecuteReader();

            while (RulesReader.Read())
            {
                rules.Add(new RuleDTO()
                {
                    RuleId = (int)RulesReader["Id"],
                    SystemId = (int)RulesReader["SystemId"],
                    Min = (int)RulesReader["Min"],
                    Max = (int)RulesReader["Max"],
                    Name = (string)RulesReader["Name"],
                    NotifyEmail = (string)RulesReader["NotifyEmail"]
                });
            }

            CloseConnect();
            return rules;
        }

        public RuleDTO GetRuleTypeFromServer(int serverId, string typeName)
        {
            OpenConnect();

            RuleDTO rule = new RuleDTO();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Rules WHERE SystemId = @systemId and Name = @name";
            cmd.Parameters.AddWithValue("@systemId", serverId);
            cmd.Parameters.AddWithValue("@name", typeName);

            using SqlDataReader RulesReader = cmd.ExecuteReader();

            while (RulesReader.Read())
            {
                rule = new RuleDTO()
                {
                    RuleId = (int)RulesReader["Id"],
                    SystemId = (int)RulesReader["SystemId"],
                    Min = (int)RulesReader["Min"],
                    Max = (int)RulesReader["Max"],
                    Name = (string)RulesReader["Name"],
                    NotifyEmail = (string)RulesReader["NotifyEmail"]
                };
            }

            CloseConnect();
            return rule;
        }
    }
}
