
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.HomeBtn = new System.Windows.Forms.Button();
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
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(380, 258);
            this.cpuChart.TabIndex = 4;
            this.cpuChart.Text = "Cpu";
            // 
            // gpuChart
            // 
            chartArea2.Name = "ChartArea1";
            this.gpuChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gpuChart.Legends.Add(legend2);
            this.gpuChart.Location = new System.Drawing.Point(436, 112);
            this.gpuChart.Name = "gpuChart";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "GPU";
            this.gpuChart.Series.Add(series2);
            this.gpuChart.Size = new System.Drawing.Size(380, 258);
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
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "RAM";
            this.ramChart.Series.Add(series3);
            this.ramChart.Size = new System.Drawing.Size(380, 258);
            this.ramChart.TabIndex = 6;
            this.ramChart.Text = "chart3";
            // 
            // diskChart
            // 
            chartArea4.Name = "ChartArea1";
            this.diskChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.diskChart.Legends.Add(legend4);
            this.diskChart.Location = new System.Drawing.Point(436, 396);
            this.diskChart.Name = "diskChart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Disk";
            this.diskChart.Series.Add(series4);
            this.diskChart.Size = new System.Drawing.Size(380, 258);
            this.diskChart.TabIndex = 7;
            this.diskChart.Text = "chart4";
            // 
            // networkChart
            // 
            chartArea5.Name = "ChartArea1";
            this.networkChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.networkChart.Legends.Add(legend5);
            this.networkChart.Location = new System.Drawing.Point(822, 112);
            this.networkChart.Name = "networkChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Network";
            this.networkChart.Series.Add(series5);
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
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.HomeBtn.FlatAppearance.BorderSize = 2;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.HomeBtn.Location = new System.Drawing.Point(50, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(138, 40);
            this.HomeBtn.TabIndex = 14;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.HomeBtn);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button HomeBtn;
    }
}