using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IServerContainer
    {
        public List<ServerDTO> GetAllSystems();

        public ServerDTO GetOneSystemByName(ServerDTO dto);

        public ServerDTO GetOneSystemById(int systemId);

        public List<MetricDTO> GetExceedingMetricsFromServer(int serverId);
    }
}
