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
        public int ServerId { get; set; }
        public string ServerName { get; set; }

        IServer ISystem;

        public Server()
        {

        }

        public Server(int id)
        {
            this.ServerId = id;
        }

        public Server(string name)
        {
            this.ServerName = name;
        }

        public Server(int id, string name)
        {
            this.ServerId = id;
            this.ServerName = name;
        }

        public Server(IServer dal)
        {
            ISystem = dal;
        }

        public Server(ServerDTO dto)
        {
            this.ServerId = dto.SystemId;
            this.ServerName = dto.SystemName;
        }

        public ServerDTO ToDTO()
        {
            ServerDTO dto = new ServerDTO();
            dto.SystemId = ServerId;
            dto.SystemName = ServerName;
            return dto;
        }
    }
}
