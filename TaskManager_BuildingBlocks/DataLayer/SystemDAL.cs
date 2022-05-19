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
    public class SystemDAL : SqlConnect, IServer, IServerContainer
    {
        public SystemDAL()
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

        public Dictionary<ServerDTO, List<MetricDTO>> GetMetricsFromServer(int serverId)
        {
            OpenConnect();

            Dictionary<ServerDTO, List<MetricDTO>> dict = new Dictionary<ServerDTO, List<MetricDTO>>();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT DISTINCT Name FROM Metrics WHERE SytemId = @systemId";
            cmd.Parameters.AddWithValue("@systemId", serverId);

            using SqlDataReader metricReader = cmd.ExecuteReader();

            while(metricReader.Read()){
                
            }

            CloseConnect();
            return dict;
        }
    }
}
