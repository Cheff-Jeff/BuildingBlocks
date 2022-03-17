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
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            cpuChart.Series[0].ChartType = SeriesChartType.Line;
            cpuChart.Series["Max"].ChartType = SeriesChartType.Line;
            cpuChart.Series["Min"].ChartType = SeriesChartType.Line;
            cpuChart.Series[0].IsValueShownAsLabel = true;
            cpuChart.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) cpuChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { cpuChart.Series["Max"].Points.AddXY(x[i], 90); cpuChart.Series["Min"].Points.AddXY(x[i], 15); }
        }

        private void GenerateGPUChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            gpuChart.Series[0].ChartType = SeriesChartType.Line;
            gpuChart.Series[0].IsValueShownAsLabel = true;
            gpuChart.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) gpuChart.Series[0].Points.AddXY(x[i], y[i]);
        }

        private void GenerateRAMChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            ramChart.Series[0].ChartType = SeriesChartType.Line;
            ramChart.Series[0].IsValueShownAsLabel = true;
            ramChart.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) ramChart.Series[0].Points.AddXY(x[i], y[i]);
        }

        private void GenerateDiskChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            diskChart.Series[0].ChartType = SeriesChartType.Line;
            diskChart.Series[0].IsValueShownAsLabel = true;
            diskChart.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) diskChart.Series[0].Points.AddXY(x[i], y[i]); 
        }

        private void GenerateNetworkChart()
        {

            //Get the latest this many.
            int xAmount = 5;
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = random.Next(10, 90);
            }

            networkChart.Series[0].ChartType = SeriesChartType.Line;
            networkChart.Series[0].IsValueShownAsLabel = true;
            networkChart.ChartAreas[0].AxisY.ScaleView.Size = 100;
            for (int i = 0; i < x.Length; i++) networkChart.Series[0].Points.AddXY(x[i], y[i]); 
        }
    }
}
