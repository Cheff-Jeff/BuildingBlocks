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
    public class MetricDAL : SqlConnect, IMetric, IMetricContainer
    {

        public void CreateMetric(NewMetricDTO metric)
        {
            Initialize();
            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO Metrics (Name, SystemId, Value, Date) Values (@name, @systemId, @value, @date)";
                cmd.Parameters.AddWithValue("@name", metric.Name);
                cmd.Parameters.AddWithValue("@systemId", metric.SystemId);
                cmd.Parameters.AddWithValue("@value", metric.Value);
                cmd.Parameters.AddWithValue("@date", metric.Date);

                cmd.ExecuteNonQuery();

                CloseConnect();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                throw;
            }
        }
        public List<MetricDTO> GetAllLatestMetricsFromServer(int serverId)
        {

            Initialize();
            OpenConnect();

            cmd.Dispose();

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT M.* FROM (SELECT Name, Max(Date) AS First FROM Metrics WHERE SystemId = @systemId GROUP BY Name) foo JOIN Metrics M ON foo.Name = M.Name AND foo.First = M.Date";
            cmd.Parameters.AddWithValue("@systemId", serverId);

            using SqlDataReader metricReader = cmd.ExecuteReader();

            List<MetricDTO> metrics = new List<MetricDTO>();

            while (metricReader.Read())
            {
                metrics.Add(new MetricDTO((int)metricReader["Id"], (string)metricReader["Name"], serverId, (int)metricReader["Value"], (DateTime)metricReader["Date"]));
            }

            CloseConnect();
            return metrics;
        }
        public List<MetricDTO> GetAllMetricsFromServerWithName(int serverId, string name, int amount)
        {
            Initialize();
            OpenConnect();

            cmd.Dispose();

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT TOP " + amount + " * FROM Metrics WHERE SystemId = @systemId AND Name = @name ORDER BY Date DESC";
            cmd.Parameters.AddWithValue("@systemId", serverId);
            cmd.Parameters.AddWithValue("@name", name);

            using SqlDataReader metricReader = cmd.ExecuteReader();

            List<MetricDTO> metrics = new List<MetricDTO>();

            while (metricReader.Read())
            {
                metrics.Add(new MetricDTO((int)metricReader["Id"], (string)metricReader["Name"], serverId, (int)metricReader["Value"], (DateTime)metricReader["Date"]));
            }

            CloseConnect();
            return metrics;
        }
    }
}
