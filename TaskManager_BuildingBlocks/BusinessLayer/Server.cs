using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Server
    {
        public int SystemId { get; set; }
        public string SystemName { get; set; }

        ISystem ISystem;

        public Server()
        {

        }

        public Server(int id)
        {
            this.SystemId = id;
        }

        public Server(string name)
        {
            this.SystemName = name;
        }

        public Server(int id, string name)
        {
            this.SystemId = id;
            this.SystemName = name;
        }

        public Server(ISystem dal)
        {
            ISystem = dal;
        }

        public Server(SystemDTO dto)
        {
            this.SystemId = dto.SystemId;
            this.SystemName = dto.SystemName;
        }

        public SystemDTO ToDTO()
        {
            SystemDTO dto = new SystemDTO();
            dto.SystemId = SystemId;
            dto.SystemName = SystemName;
            return dto;
        }
    }
}
