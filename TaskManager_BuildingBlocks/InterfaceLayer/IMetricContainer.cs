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
        public void CreateMetric(MetricDTO metric);
    }
}
