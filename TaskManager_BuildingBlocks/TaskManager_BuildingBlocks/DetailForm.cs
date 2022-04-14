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
        int xAmount = 10;

        public DetailForm(int systemId)
        {
            
            InitializeComponent();
            charts = new Chart[] { cpuChart, gpuChart, ramChart, diskChart, networkChart };
            GenerateCharts(systemId);
        }

        private void GenerateCharts(int id)
        {
            for (int i = 0; i < charts.Length; i++)
            {
                charts[i].Series[0].IsValueShownAsLabel = true;
                Series srMx = new Series("Max");
                Series srMn = new Series("Min");
                charts[i].Series.Add(srMx);
                charts[i].Series.Add(srMn);
                charts[i].ChartAreas[0].AxisY.ScaleView.Size = 10000;
                for (int j = 0; j <= 2; j++)
                {
                    charts[i].Series[j].IsVisibleInLegend = false;
                    charts[i].Series[j].BorderWidth = 2;
                    charts[i].Series[j].ChartType = SeriesChartType.Line;
                }
            }

            CsvReader csvReader = new CsvReader();

            PcData alldata = csvReader.GetData(id);
            

            GenerateCPUChart(alldata.CPU, 3000, 8000);
            GenerateGPUChart(alldata.GPU, 2500, 9000);
            GenerateRAMChart(alldata.Ram, 1500, 7500);
            GenerateDiskChart(alldata.Disk, 3500, 7300);
            GenerateNetworkChart(alldata.Network, 2500, 9500);
        }

        private void GenerateCPUChart(List<int> data, int min, int max)
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = data[i];
            }

            for (int i = 0; i < x.Length; i++) cpuChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { cpuChart.Series["Max"].Points.AddXY(x[i], max); cpuChart.Series["Min"].Points.AddXY(x[i], min); }
        }

        private void GenerateGPUChart(List<int> data, int min, int max)
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = data[i];
            }

            for (int i = 0; i < x.Length; i++) gpuChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { gpuChart.Series["Max"].Points.AddXY(x[i], max); gpuChart.Series["Min"].Points.AddXY(x[i], min); }
        }

        private void GenerateRAMChart(List<int> data, int min, int max)
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = data[i];
            }

            for (int i = 0; i < x.Length; i++) ramChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { ramChart.Series["Max"].Points.AddXY(x[i], max); ramChart.Series["Min"].Points.AddXY(x[i], min); }
        }

        private void GenerateDiskChart(List<int> data, int min, int max)
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = data[i];
            }

            for (int i = 0; i < x.Length; i++) diskChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { diskChart.Series["Max"].Points.AddXY(x[i], max); diskChart.Series["Min"].Points.AddXY(x[i], min); }
        }

        private void GenerateNetworkChart(List<int> data, int min, int max)
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = data[i];
            }

            for (int i = 0; i < x.Length; i++) networkChart.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++) { networkChart.Series["Max"].Points.AddXY(x[i], max); networkChart.Series["Min"].Points.AddXY(x[i], min); }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            //home.Show();
            this.Close();
        }

        private void systemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (systemComboBox.SelectedItem.ToString())
            {
                case "Ram":
                    ChartLbl.Text = "Ram";
                    break;
                case "CPU":
                    ChartLbl.Text = "CPU";
                    break;
                case "GPU":
                    ChartLbl.Text = "GPU";
                    break;
                case "Disk":
                    ChartLbl.Text = "Disk";
                    break;
                case "Network":
                    ChartLbl.Text = "Network";
                    break;
                default:
                    ChartLbl.Text = "GPU";
                    break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
