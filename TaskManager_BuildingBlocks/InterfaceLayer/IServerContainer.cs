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

        public ServerDTO GetOneSystemNameById(ServerDTO dto);

        public Dictionary<ServerDTO, List<MetricDTO>> GetMetricsFromServer(int serverId);
    }
}
