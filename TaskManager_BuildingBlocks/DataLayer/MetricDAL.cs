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
    class MetricDAL : SqlConnect, IMetric, IMetricContainer
    {
        public MetricDAL()
        {

        }

        public void CreateMetric(MetricDTO metric)
        {
            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO Metrics (Name, SystemId, Value, Date) Values (@name, @systemId, @value, @date)";
                cmd.Parameters.AddWithValue("@name", metric.Name);
                cmd.Parameters.AddWithValue("@systemId", metric.SystemId);
                cmd.Parameters.AddWithValue("@value", metric.Value);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

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
    }
}
