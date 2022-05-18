﻿using InterfaceLayer;
using InterfaceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Metric
    {
        public int MetricId { get; set; }
        public string Name { get; set; }
        public int SystemId { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }

        IMetric IMetric;

        public Metric()
        {

        }

        public Metric(IMetric dal)
        {
            IMetric = dal;
        }

        public Metric(MetricDTO dto)
        {
            this.MetricId = dto.MetricId;
            this.Name = dto.Name;
            this.SystemId = dto.SystemId;
            this.Value = dto.Value;
            this.Date = dto.Date;
        }
    }
}