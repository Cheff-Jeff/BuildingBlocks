
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diskChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.networkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            chartArea6.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.cpuChart.Legends.Add(legend6);
            this.cpuChart.Location = new System.Drawing.Point(50, 112);
            this.cpuChart.Name = "cpuChart";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "CPU";
            this.cpuChart.Series.Add(series6);
            this.cpuChart.Size = new System.Drawing.Size(380, 258);
            this.cpuChart.TabIndex = 4;
            this.cpuChart.Text = "Cpu";
            // 
            // gpuChart
            // 
            chartArea7.Name = "ChartArea1";
            this.gpuChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.gpuChart.Legends.Add(legend7);
            this.gpuChart.Location = new System.Drawing.Point(436, 112);
            this.gpuChart.Name = "gpuChart";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "GPU";
            this.gpuChart.Series.Add(series7);
            this.gpuChart.Size = new System.Drawing.Size(380, 258);
            this.gpuChart.TabIndex = 5;
            this.gpuChart.Text = "chart2";
            // 
            // ramChart
            // 
            chartArea8.Name = "ChartArea1";
            this.ramChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.ramChart.Legends.Add(legend8);
            this.ramChart.Location = new System.Drawing.Point(50, 396);
            this.ramChart.Name = "ramChart";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "RAM";
            this.ramChart.Series.Add(series8);
            this.ramChart.Size = new System.Drawing.Size(380, 258);
            this.ramChart.TabIndex = 6;
            this.ramChart.Text = "chart3";
            // 
            // diskChart
            // 
            chartArea9.Name = "ChartArea1";
            this.diskChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.diskChart.Legends.Add(legend9);
            this.diskChart.Location = new System.Drawing.Point(436, 396);
            this.diskChart.Name = "diskChart";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Disk";
            this.diskChart.Series.Add(series9);
            this.diskChart.Size = new System.Drawing.Size(380, 258);
            this.diskChart.TabIndex = 7;
            this.diskChart.Text = "chart4";
            // 
            // networkChart
            // 
            chartArea10.Name = "ChartArea1";
            this.networkChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.networkChart.Legends.Add(legend10);
            this.networkChart.Location = new System.Drawing.Point(822, 112);
            this.networkChart.Name = "networkChart";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Network";
            this.networkChart.Series.Add(series10);
            this.networkChart.Size = new System.Drawing.Size(380, 258);
            this.networkChart.TabIndex = 8;
            this.networkChart.Text = "chart5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(432, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "GPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(818, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Network";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(46, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(432, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Disk";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart gpuChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ramChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart diskChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart networkChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}