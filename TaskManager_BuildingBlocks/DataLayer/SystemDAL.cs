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
    public class SystemDAL : SqlConnect, ISystem, ISystemContainer
    {
        public SystemDAL()
        {
            Initialize();
        }

        public List<SystemDTO> GetAllSystems()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Systems";
            using SqlDataReader rdr = cmd.ExecuteReader();

            List<SystemDTO> listall = new List<SystemDTO>();

            while (rdr.Read())
            {
                SystemDTO system = new SystemDTO()
                {
                    SystemId = rdr.GetInt32("Id"),
                    SystemName = rdr.GetString("Name"),
                };
                listall.Add(system);
            }
            CloseConnect();

            return listall;
        }

        public SystemDTO GetOneSystemByName(SystemDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Systems WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", dto.SystemName);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            SystemDTO system = new SystemDTO()
            {
                SystemId = rdr.GetInt32("Id"),
                SystemName = rdr.GetString("Name"),
            };
            CloseConnect();
            return system;
        }

        public SystemDTO GetOneSystemNameById(SystemDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Systems WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", dto.SystemId);

            using SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            SystemDTO system = new SystemDTO()
            {
                SystemId = rdr.GetInt32("Id"),
                SystemName = rdr.GetString("Name"),
            };
            CloseConnect();
            return system;
        }
    }
}
