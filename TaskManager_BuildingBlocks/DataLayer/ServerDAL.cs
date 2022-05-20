using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ServerDAL : SqlConnect, IServer, IServerContainer
    {
        public ServerDAL()
        {
            Initialize();
        }

        public List<ServerDTO> GetAllSystems()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Systems";
            using SqlDataReader rdr = cmd.ExecuteReader();

            List<ServerDTO> listall = new List<ServerDTO>();

            while (rdr.Read())
            {
                ServerDTO system = new ServerDTO()
                {
                    SystemId = rdr.GetInt32("Id"),
                    SystemName = rdr.GetString("Name"),
                };
                listall.Add(system);
            }
            CloseConnect();

            return listall;
        }

        public ServerDTO GetOneSystemByName(ServerDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Systems WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", dto.SystemName);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            ServerDTO system = new ServerDTO()
            {
                SystemId = rdr.GetInt32("Id"),
                SystemName = rdr.GetString("Name"),
            };
            CloseConnect();
            return system;
        }

        public ServerDTO GetOneSystemNameById(ServerDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Systems WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", dto.SystemId);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            ServerDTO system = new ServerDTO()
            {
                SystemId = rdr.GetInt32("Id"),
                SystemName = rdr.GetString("Name"),
            };
            CloseConnect();
            return system;
        }

        public List<MetricDTO> GetExceedingMetricsFromServer(int serverId)
        {
            List<MetricDTO> exceedingMetrics = new List<MetricDTO>();

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
            OpenConnect();

            cmd.Dispose();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Metrics WHERE SystemId = @systemId group by Name, Id, SystemId, Value, Date order by Id desc";
            RuleDTO currentRule = rules.Find(rule => rule.SystemId == serverId);
            List<string> usedNames = new List<string>();
            cmd.Parameters.AddWithValue("@systemId", serverId);

            using SqlDataReader metricReader = cmd.ExecuteReader();

            List<MetricDTO> metrics = new List<MetricDTO>();

            while (metricReader.Read())
            {
                metrics.Add(new MetricDTO((int)metricReader["Id"], (string)metricReader["Name"], (int)metricReader["SystemId"], (int)metricReader["Value"], (DateTime)metricReader["Date"]));
            }

            foreach (var metric in metrics)
            {
                if (!usedNames.Contains(metric.Name))
                {
                    var thisRule = rules.Find(rule => rule.Name == metric.Name);
                    if (thisRule != null)
                    {
                        Console.WriteLine(metric.Value);
                        Console.WriteLine(metric.MetricId);
                        if (thisRule.Min > metric.Value || thisRule.Max < metric.Value)
                        {
                            exceedingMetrics.Add(metric); Console.WriteLine(metric.Value);
                        }
                    }
                }
                usedNames.Add(metric.Name);
            }

            CloseConnect();
            return exceedingMetrics;
        }
    }
}
