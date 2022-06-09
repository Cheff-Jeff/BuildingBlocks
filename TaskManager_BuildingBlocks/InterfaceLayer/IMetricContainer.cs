using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IMetricContainer
    {
        public void CreateMetric(NewMetricDTO metric);
        public List<MetricDTO> GetAllLatestMetricsFromServer(int serverId);
        public List<MetricDTO> GetAllMetricsFromServer(int serverId);
        public List<MetricDTO> GetAllMetricsFromServerWithName(int serverId, string name, int amount);
    }
}
