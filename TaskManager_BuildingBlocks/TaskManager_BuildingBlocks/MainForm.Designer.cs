﻿
namespace TaskManager_BuildingBlocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.systemComboBox = new System.Windows.Forms.ComboBox();
            this.exceedingSystemDataGrid = new System.Windows.Forms.DataGridView();
            this.System_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Network_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exceedingSystemDataGrid)).BeginInit();
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
            this.systemComboBox.TabIndex = 2;
            this.systemComboBox.SelectedIndexChanged += new System.EventHandler(this.systemComboBox_SelectedIndexChanged);
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
            this.Network_usage});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exceedingSystemDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.exceedingSystemDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.exceedingSystemDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exceedingSystemDataGrid.Location = new System.Drawing.Point(50, 124);
            this.exceedingSystemDataGrid.Name = "exceedingSystemDataGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exceedingSystemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.exceedingSystemDataGrid.RowHeadersVisible = false;
            this.exceedingSystemDataGrid.RowHeadersWidth = 50;
            this.exceedingSystemDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.exceedingSystemDataGrid.Size = new System.Drawing.Size(817, 442);
            this.exceedingSystemDataGrid.TabIndex = 3;
            this.exceedingSystemDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exceedingSystemDataGrid_CellClick);
            this.exceedingSystemDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.exceedingSystemDataGrid_CellFormatting);
            // 
            // System_Id
            // 
            this.System_Id.HeaderText = "System";
            this.System_Id.Name = "System_Id";
            this.System_Id.Width = 300;
            // 
            // CPU_usage
            // 
            this.CPU_usage.HeaderText = "CPU";
            this.CPU_usage.Name = "CPU_usage";
            // 
            // GPU_usage
            // 
            this.GPU_usage.HeaderText = "GPU";
            this.GPU_usage.Name = "GPU_usage";
            // 
            // RAM_usage
            // 
            this.RAM_usage.HeaderText = "RAM";
            this.RAM_usage.Name = "RAM_usage";
            // 
            // Disk_usage
            // 
            this.Disk_usage.HeaderText = "Disk";
            this.Disk_usage.Name = "Disk_usage";
            // 
            // Network_usage
            // 
            this.Network_usage.HeaderText = "Network";
            this.Network_usage.Name = "Network_usage";
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.SystemColors.Control;
            this.createUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.createUserBtn.FlatAppearance.BorderSize = 2;
            this.createUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.createUserBtn.Location = new System.Drawing.Point(1041, 56);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(138, 40);
            this.createUserBtn.TabIndex = 11;
            this.createUserBtn.Text = "Create User";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.logoutBtn.FlatAppearance.BorderSize = 2;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.logoutBtn.Location = new System.Drawing.Point(897, 56);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(138, 40);
            this.logoutBtn.TabIndex = 12;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.exceedingSystemDataGrid);
            this.Controls.Add(this.systemComboBox);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exceedingSystemDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox systemComboBox;
        private System.Windows.Forms.DataGridView exceedingSystemDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn System_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Network_usage;
        private System.Windows.Forms.Button createUserBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}

