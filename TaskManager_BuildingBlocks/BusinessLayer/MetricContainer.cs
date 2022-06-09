using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MetricContainer
    {
        private IMetricContainer Metrics;
        public MetricContainer(IMetricContainer metricContainer)
        {
            Metrics = metricContainer;
        }
        public void CreateMetric(NewMetric metric)
        {
            Metrics.CreateMetric(new NewMetricDTO(metric.Name, metric.SystemId, metric.Value, DateTime.Now));
        }

        public List<Metric> GetAllMetricsFromServer(int serverId)
        {
            List<Metric> mets = new List<Metric>();
            Metrics.GetAllMetricsFromServer(serverId).ForEach(m => mets.Add(new Metric(m)));
            return mets;
        }

        public List<Metric> GetAllLatestMetricsFromServer(int serverId)
        {
            List<Metric> mets = new List<Metric>();
            Metrics.GetAllLatestMetricsFromServer(serverId).ForEach(m => mets.Add(new Metric(m)));
            return mets;
        }

        public List<Metric> GetAllMetricsFromServerWithName(int id, string name, int amount)
        {
            List<Metric> mets = new List<Metric>();
            Metrics.GetAllMetricsFromServerWithName(id, name, amount).ForEach(m => mets.Add(new Metric(m)));
            return mets;
        }
    }
}
