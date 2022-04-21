
namespace ViewLayer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.exceedingSystemDataGrid = new System.Windows.Forms.DataGridView();
            this.System_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Network_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.btManageusers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exceedingSystemDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // systemComboBox
            // 
            this.systemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.systemComboBox.FormattingEnabled = true;
            this.systemComboBox.Items.AddRange(new object[] {
            "System 1",
            "System 2",
            "System 3",
            "System 4"});
            this.systemComboBox.Location = new System.Drawing.Point(67, 92);
            this.systemComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Size = new System.Drawing.Size(465, 39);
            this.systemComboBox.TabIndex = 2;
            this.systemComboBox.SelectedIndexChanged += new System.EventHandler(this.systemComboBox_SelectedIndexChanged);
            this.systemComboBox.TextUpdate += new System.EventHandler(this.systemComboBox_TextUpdate);
            // 
            // exceedingSystemDataGrid
            // 
            this.exceedingSystemDataGrid.AllowUserToAddRows = false;
            this.exceedingSystemDataGrid.AllowUserToDeleteRows = false;
            this.exceedingSystemDataGrid.AllowUserToResizeColumns = false;
            this.exceedingSystemDataGrid.AllowUserToResizeRows = false;
            this.exceedingSystemDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.exceedingSystemDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exceedingSystemDataGrid.ColumnHeadersHeight = 50;
            this.exceedingSystemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.exceedingSystemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.System_Id,
            this.CPU_usage,
            this.GPU_usage,
            this.RAM_usage,
            this.Disk_usage,
            this.Network_usage,
            this.ID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exceedingSystemDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.exceedingSystemDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.exceedingSystemDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exceedingSystemDataGrid.Location = new System.Drawing.Point(67, 191);
            this.exceedingSystemDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exceedingSystemDataGrid.Name = "exceedingSystemDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exceedingSystemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.exceedingSystemDataGrid.RowHeadersVisible = false;
            this.exceedingSystemDataGrid.RowHeadersWidth = 50;
            this.exceedingSystemDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.exceedingSystemDataGrid.Size = new System.Drawing.Size(1191, 680);
            this.exceedingSystemDataGrid.TabIndex = 3;
            this.exceedingSystemDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exceedingSystemDataGrid_CellClick);
            this.exceedingSystemDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.exceedingSystemDataGrid_CellFormatting);
            // 
            // System_Id
            // 
            this.System_Id.HeaderText = "System";
            this.System_Id.MinimumWidth = 6;
            this.System_Id.Name = "System_Id";
            this.System_Id.Width = 300;
            // 
            // CPU_usage
            // 
            this.CPU_usage.HeaderText = "CPU";
            this.CPU_usage.MinimumWidth = 6;
            this.CPU_usage.Name = "CPU_usage";
            this.CPU_usage.Width = 125;
            // 
            // GPU_usage
            // 
            this.GPU_usage.HeaderText = "GPU";
            this.GPU_usage.MinimumWidth = 6;
            this.GPU_usage.Name = "GPU_usage";
            this.GPU_usage.Width = 125;
            // 
            // RAM_usage
            // 
            this.RAM_usage.HeaderText = "RAM";
            this.RAM_usage.MinimumWidth = 6;
            this.RAM_usage.Name = "RAM_usage";
            this.RAM_usage.Width = 125;
            // 
            // Disk_usage
            // 
            this.Disk_usage.HeaderText = "Disk";
            this.Disk_usage.MinimumWidth = 6;
            this.Disk_usage.Name = "Disk_usage";
            this.Disk_usage.Width = 125;
            // 
            // Network_usage
            // 
            this.Network_usage.HeaderText = "Network";
            this.Network_usage.MinimumWidth = 6;
            this.Network_usage.Name = "Network_usage";
            this.Network_usage.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.logoutBtn.FlatAppearance.BorderSize = 2;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.logoutBtn.Location = new System.Drawing.Point(1196, 86);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(184, 61);
            this.logoutBtn.TabIndex = 12;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // btManageusers
            // 
            this.btManageusers.BackColor = System.Drawing.SystemColors.Control;
            this.btManageusers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btManageusers.FlatAppearance.BorderSize = 2;
            this.btManageusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManageusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btManageusers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btManageusers.Location = new System.Drawing.Point(1388, 86);
            this.btManageusers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btManageusers.Name = "btManageusers";
            this.btManageusers.Size = new System.Drawing.Size(184, 61);
            this.btManageusers.TabIndex = 13;
            this.btManageusers.Text = "Manage Users";
            this.btManageusers.UseVisualStyleBackColor = false;
            this.btManageusers.Click += new System.EventHandler(this.btManageusers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1035);
            this.Controls.Add(this.btManageusers);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.exceedingSystemDataGrid);
            this.Controls.Add(this.systemComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1701, 1082);
            this.MinimumSize = new System.Drawing.Size(1701, 1028);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exceedingSystemDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.DataGridView exceedingSystemDataGrid;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn System_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Network_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btManageusers;
    }
}

