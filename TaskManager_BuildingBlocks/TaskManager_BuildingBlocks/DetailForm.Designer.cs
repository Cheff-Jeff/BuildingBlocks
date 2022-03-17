
namespace TaskManager_BuildingBlocks
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diskChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.networkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkChart)).BeginInit();
            this.SuspendLayout();
            // 
            // systemComboBox
            // 
            this.systemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.systemComboBox.FormattingEnabled = true;
            this.systemComboBox.Items.AddRange(new object[] {
            "System 1",
            "System 2",
            "System 3",
            "System 4"});
            this.systemComboBox.Location = new System.Drawing.Point(50, 60);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Size = new System.Drawing.Size(350, 33);
            this.systemComboBox.TabIndex = 3;
            // 
            // cpuChart
            // 
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart.Legends.Add(legend1);
            this.cpuChart.Location = new System.Drawing.Point(50, 112);
            this.cpuChart.Name = "cpuChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Max";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Min";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Series.Add(series2);
            this.cpuChart.Series.Add(series3);
            this.cpuChart.Size = new System.Drawing.Size(300, 258);
            this.cpuChart.TabIndex = 4;
            this.cpuChart.Text = "chart1";
            // 
            // gpuChart
            // 
            chartArea2.Name = "ChartArea1";
            this.gpuChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gpuChart.Legends.Add(legend2);
            this.gpuChart.Location = new System.Drawing.Point(384, 112);
            this.gpuChart.Name = "gpuChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "GPU";
            this.gpuChart.Series.Add(series4);
            this.gpuChart.Size = new System.Drawing.Size(300, 258);
            this.gpuChart.TabIndex = 5;
            this.gpuChart.Text = "chart2";
            // 
            // ramChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ramChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ramChart.Legends.Add(legend3);
            this.ramChart.Location = new System.Drawing.Point(50, 396);
            this.ramChart.Name = "ramChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "RAM";
            this.ramChart.Series.Add(series5);
            this.ramChart.Size = new System.Drawing.Size(300, 258);
            this.ramChart.TabIndex = 6;
            this.ramChart.Text = "chart3";
            // 
            // diskChart
            // 
            chartArea4.Name = "ChartArea1";
            this.diskChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.diskChart.Legends.Add(legend4);
            this.diskChart.Location = new System.Drawing.Point(384, 396);
            this.diskChart.Name = "diskChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Disk";
            this.diskChart.Series.Add(series6);
            this.diskChart.Size = new System.Drawing.Size(300, 258);
            this.diskChart.TabIndex = 7;
            this.diskChart.Text = "chart4";
            // 
            // networkChart
            // 
            chartArea5.Name = "ChartArea1";
            this.networkChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.networkChart.Legends.Add(legend5);
            this.networkChart.Location = new System.Drawing.Point(717, 112);
            this.networkChart.Name = "networkChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Network";
            this.networkChart.Series.Add(series7);
            this.networkChart.Size = new System.Drawing.Size(300, 258);
            this.networkChart.TabIndex = 8;
            this.networkChart.Text = "chart5";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.networkChart);
            this.Controls.Add(this.diskChart);
            this.Controls.Add(this.ramChart);
            this.Controls.Add(this.gpuChart);
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.systemComboBox);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart gpuChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart diskChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart networkChart;
    }
}