using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PdfPrintViewModel
    {
        public string ServerName { get; set; }

        public string MetricName { get; set; }

        public DateTime Date { get; set; }

        public int Percentage { get; set; }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public PdfPrintViewModel()
        {

        }

        public PdfPrintViewModel(string systemname, string metricname, int percentage, DateTime date)
        {
            this.ServerName = systemname;
            this.MetricName = metricname;
            this.Date = date;
            this.Percentage = percentage;
        }
    }
}
