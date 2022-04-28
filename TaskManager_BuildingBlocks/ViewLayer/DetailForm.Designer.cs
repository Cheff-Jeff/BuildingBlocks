
namespace ViewLayer
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
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // systemComboBox
            // 
            this.systemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.systemComboBox.FormattingEnabled = true;
            this.systemComboBox.Items.AddRange(new object[] {
            "CPU",
            "GPU",
            "Ram",
            "Disk",
            "Network"});
            this.systemComboBox.Location = new System.Drawing.Point(67, 74);
            this.systemComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Size = new System.Drawing.Size(465, 39);
            this.systemComboBox.TabIndex = 3;
            this.systemComboBox.SelectedIndexChanged += new System.EventHandler(this.systemComboBox_SelectedIndexChanged);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.HomeBtn.FlatAppearance.BorderSize = 2;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.HomeBtn.Location = new System.Drawing.Point(67, 15);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(184, 49);
            this.HomeBtn.TabIndex = 14;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(67, 166);
            this.Chart1.Margin = new System.Windows.Forms.Padding(4);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Network";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(507, 318);
            this.Chart1.TabIndex = 15;
            this.Chart1.Text = "chart5";
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // ChartLbl
            // 
            this.ChartLbl.AutoSize = true;
            this.ChartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChartLbl.Location = new System.Drawing.Point(62, 137);
            this.ChartLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChartLbl.Name = "ChartLbl";
            this.ChartLbl.Size = new System.Drawing.Size(54, 25);
            this.ChartLbl.TabIndex = 16;
            this.ChartLbl.Text = "GPU";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.ChartLbl);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.systemComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Label ChartLbl;
    }
}