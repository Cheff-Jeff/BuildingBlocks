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
        int xAmount = 10;
        PcData alldata;
        Chart[] charts;

        public DetailForm(int systemId)
        {
            InitializeComponent();
            charts = new Chart[] { Chart1 };
            CsvReader csvReader = new CsvReader();
            alldata = csvReader.GetData(systemId);
            GenerateChart();
            DataToChart(alldata.GPU, 2500, 9000);
        }

        private void GenerateChart()
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
            
        }

        private void DataToChart(List<int> data, int min, int max)
        {
            string[] x = new string[xAmount];
            int[] y = new int[xAmount];
            for (var i = 0; i < xAmount; i++)
            {
                Console.WriteLine("forloop time " + i);
                x[i] = i.ToString();
                y[i] = data[i];
            }

            for (int i = 0; i < x.Length; i++) Chart1.Series[0].Points.AddXY(x[i], y[i]);
            for (int i = 0; i < x.Length; i++)
            {
                Chart1.Series["Max"].Points.AddXY(0, max); Chart1.Series["Min"].Points.AddXY(0, min);
            }
        }

        private void ClearChart()
        {
            Chart1.Series[0].Points.Clear();
            Chart1.Series["Max"].Points.Clear();
            Chart1.Series["Min"].Points.Clear();
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
                    ClearChart();
                    DataToChart(alldata.Ram, 1500, 7500);
                    break;
                case "CPU":
                    ChartLbl.Text = "CPU";
                    ClearChart();
                    DataToChart(alldata.CPU, 3000, 8000);
                    break;
                case "GPU":
                    ChartLbl.Text = "GPU";
                    ClearChart();
                    DataToChart(alldata.GPU, 2500, 9000);
                    break;
                case "Disk":
                    ChartLbl.Text = "Disk";
                    ClearChart();
                    DataToChart(alldata.Disk, 3500, 7300);
                    break;
                case "Network":
                    ChartLbl.Text = "Network";
                    ClearChart();
                    DataToChart(alldata.Network, 2500, 9500);
                    break;
            }
        }
    }
}
