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
    }
}
