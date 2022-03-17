using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskManager_BuildingBlocks
{
    public partial class DetailForm : Form
    {
        Random random = new Random();
        Chart[] charts;
        int xAmount = 20;

        public DetailForm(int systemId)
        {
            InitializeComponent();
            charts = new Chart[] { cpuChart, gpuChart, ramChart, diskChart, networkChart };
            GenerateCharts();
        }

        private void GenerateCharts()
        {
            for (int i = 0; i < charts.Length; i++)
            {
                charts[i].Series[0].IsValueShownAsLabel = true;
                Series srMx = new Series("Max");
                Series srMn = new Series("Min");
                charts[i].Series.Add(srMx);
                charts[i].Series.Add(srMn);
                charts[i].ChartAreas[0].AxisY.ScaleView.Size = 100;
                for (int j = 0; j <= 2; j++)
                {
                    charts[i].Series[j].IsVisibleInLegend = false;
                    charts[i].Series[j].BorderWidth = 2;
                    charts[i].Series[j].ChartType = SeriesChartType.Line;
                }
            }

            GenerateCPUChart();
            GenerateGPUChart();
            GenerateRAMChart();
            GenerateDiskChart();
            GenerateNetworkChart();
        }

        private void GenerateCPUChart()
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            for (int i = 0; i < x.Length; i++) cpuChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { cpuChart.Series["Max"].Points.AddXY(x[i], 90); cpuChart.Series["Min"].Points.AddXY(x[i], 15); }
        }

        private void GenerateGPUChart()
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            for (int i = 0; i < x.Length; i++) gpuChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { gpuChart.Series["Max"].Points.AddXY(x[i], 90); gpuChart.Series["Min"].Points.AddXY(x[i], 15); }
        }

        private void GenerateRAMChart()
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            for (int i = 0; i < x.Length; i++) ramChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { ramChart.Series["Max"].Points.AddXY(x[i], 90); ramChart.Series["Min"].Points.AddXY(x[i], 15); }
        }

        private void GenerateDiskChart()
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            for (int i = 0; i < x.Length; i++) diskChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { diskChart.Series["Max"].Points.AddXY(x[i], 90); diskChart.Series["Min"].Points.AddXY(x[i], 15); }
        }

        private void GenerateNetworkChart()
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            for (int i = 0; i < x.Length; i++) networkChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { networkChart.Series["Max"].Points.AddXY(x[i], 90); networkChart.Series["Min"].Points.AddXY(x[i], 15); }
        }
    }
}
