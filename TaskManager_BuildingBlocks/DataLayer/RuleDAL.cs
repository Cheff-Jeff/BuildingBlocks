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
    public class RuleDal : SqlConnect, IRule, IRuleContainer
    {
        public RuleDal()
        {
            Initialize();
        }

        public bool AddRule(RuleDTO ruleDTO)
        {
            bool succeeded = false;
            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO Rules (SystemId, Min, Max, NotifyEmail, Name) VALUES (@systemid, @min, @max, @notifyemail, @name)";

                cmd.Parameters.AddWithValue("@systemid", ruleDTO.SystemId);
                cmd.Parameters.AddWithValue("@name", ruleDTO.RuleName);
                cmd.Parameters.AddWithValue("@min", ruleDTO.Min);
                cmd.Parameters.AddWithValue("@max", ruleDTO.Max);
                cmd.Parameters.AddWithValue("@notifyemail", ruleDTO.NotifyEmail);

                if (cmd.ExecuteNonQuery() > 0) { succeeded = true; }
                else { succeeded = false; }

                CloseConnect();

                return succeeded;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                throw;
            }
        }

        public RuleDTO GetRule(int id)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Rules WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", id);

            using SqlDataReader rdr = cmd.ExecuteReader();

            RuleDTO rule1 = new RuleDTO();

            while (rdr.Read())
            {
                RuleDTO rule = new RuleDTO((int)rdr["Id"], (string)rdr["Name"], (int)rdr["SystemId"], (int)rdr["Min"], (int)rdr["Max"], (string)rdr["NotifyEmail"]);
                rule1 = rule;
            }
            CloseConnect();

            return rule1;
        }

        public List<RuleDTO> GetRules()
        {

            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Rules";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<RuleDTO> listall = new List<RuleDTO>();

            while (rdr.Read())
            {
                RuleDTO rule = new RuleDTO((int)rdr["Id"], (string)rdr["Name"], (int)rdr["SystemId"], (int)rdr["Min"], (int)rdr["Max"], (string)rdr["NotifyEmail"]);
                listall.Add(rule);
            }
            CloseConnect();

            return listall;
        }

        public bool RemoveRule(RuleDTO ruleDTO)
        {
            bool succeeded = false;

            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "DELETE FROM Rules WHERE Id=@id";

            cmd.Parameters.AddWithValue("@id", ruleDTO.RuleId);

            if (cmd.ExecuteNonQuery() > 0)
            {
                succeeded = true;
            }
            else { succeeded = false; }

            CloseConnect();

            return succeeded;
        }

        public bool UpdateRule(RuleDTO ruleDTO)
        {
            bool succeeded = false;

            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "UPDATE Rules SET SystemId=(@systemid), Min=(@min), Max=(@max), NotifyEmail=(@notifyemail), Name=(@name) WHERE (Id=@id)";

            cmd.Parameters.AddWithValue("@id", ruleDTO.RuleId);
            cmd.Parameters.AddWithValue("@name", ruleDTO.RuleName);
            cmd.Parameters.AddWithValue("@systemid", ruleDTO.SystemId);
            cmd.Parameters.AddWithValue("@min", ruleDTO.Min);
            cmd.Parameters.AddWithValue("@max", ruleDTO.Max);
            cmd.Parameters.AddWithValue("@notifyemail", ruleDTO.NotifyEmail);

            if (cmd.ExecuteNonQuery() > 0)
            {
                succeeded = true;
            }
            else { succeeded = false; }

            CloseConnect();

            return succeeded;
        }
    }
}
