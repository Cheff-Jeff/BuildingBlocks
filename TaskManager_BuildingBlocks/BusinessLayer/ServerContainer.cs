using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ServerContainer
    {
        IServerContainer IServer;

        public ServerContainer(IServerContainer dal)
        {
            IServer = dal;
        }

        public List<Server> GetAllSystems()
        {
            //list aanmaken en vullen.
            List<Server> allsystems = new List<Server>();
            List<ServerDTO> list = IServer.GetAllSystems();
            foreach (ServerDTO system in list)
            {
                Server newsystem = new Server(system);
                allsystems.Add(newsystem);
            }
            return allsystems;
        }

        public Server GetOneSystemByName(Server system)
        {
            ServerDTO dto = system.ToDTO();

            Server sys = new Server();
            ServerDTO Dto = IServer.GetOneSystemByName(dto);
            sys.ServerId = Dto.SystemId;
            sys.ServerName = Dto.SystemName;

            return sys;
        }

        public Server GetOneSystemNameById(Server system)
        {
            ServerDTO dto = system.ToDTO();

            Server sys = new Server();
            ServerDTO Dto = IServer.GetOneSystemNameById(dto);
            sys.ServerId = Dto.SystemId;
            sys.ServerName = Dto.SystemName;

            return sys;
        }

        public List<Metric> GetExceedingMetricsFromServer(int serverId)
        {
            List<Metric> metrics = new List<Metric>();
            IServer.GetExceedingMetricsFromServer(serverId).ForEach(r => metrics.Add(new Metric(r)));
            return metrics;
        }
    }
}
