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
        public DetailForm(int systemId)
        {
            InitializeComponent();
            GenerateCharts();
        }

        private void GenerateCharts()
        {
            GenerateCPUChart();
            GenerateGPUChart();
            GenerateRAMChart();
            GenerateDiskChart();
            GenerateNetworkChart();
        }

        private void GenerateCPUChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            Random random = new Random();
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            CpuChart.Series[0].ChartType = SeriesChartType.Line;
            CpuChart.Series[0].IsValueShownAsLabel = true;
            CpuChart.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) CpuChart.Series[0].Points.AddXY(x[i], y[i]); 
        }

        private void GenerateGPUChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            Random random = new Random();
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) chart2.Series[0].Points.AddXY(x[i], y[i]);
        }

        private void GenerateRAMChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            Random random = new Random();
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            chart3.Series[0].ChartType = SeriesChartType.Line;
            chart3.Series[0].IsValueShownAsLabel = true;
            chart3.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) chart3.Series[0].Points.AddXY(x[i], y[i]);
        }

        private void GenerateDiskChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            Random random = new Random();
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            chart4.Series[0].ChartType = SeriesChartType.Line;
            chart4.Series[0].IsValueShownAsLabel = true;
            chart4.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) chart4.Series[0].Points.AddXY(x[i], y[i]); 
        }

        private void GenerateNetworkChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            Random random = new Random();
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            chart5.Series[0].ChartType = SeriesChartType.Line;
            chart5.Series[0].IsValueShownAsLabel = true;
            chart5.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) chart5.Series[0].Points.AddXY(x[i], y[i]); 
        }
    }
}
