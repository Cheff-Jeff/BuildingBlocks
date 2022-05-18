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
    }
}
