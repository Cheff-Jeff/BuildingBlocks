﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btTestForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.systemComboBox.Location = new System.Drawing.Point(59, 69);
            this.systemComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Size = new System.Drawing.Size(407, 33);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exceedingSystemDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.exceedingSystemDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.exceedingSystemDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exceedingSystemDataGrid.Location = new System.Drawing.Point(59, 143);
            this.exceedingSystemDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exceedingSystemDataGrid.Name = "exceedingSystemDataGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exceedingSystemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.exceedingSystemDataGrid.RowHeadersVisible = false;
            this.exceedingSystemDataGrid.RowHeadersWidth = 50;
            this.exceedingSystemDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.exceedingSystemDataGrid.Size = new System.Drawing.Size(1042, 510);
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
            this.logoutBtn.Location = new System.Drawing.Point(1046, 64);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(161, 46);
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
            this.btManageusers.Location = new System.Drawing.Point(1214, 64);
            this.btManageusers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btManageusers.Name = "btManageusers";
            this.btManageusers.Size = new System.Drawing.Size(161, 46);
            this.btManageusers.TabIndex = 13;
            this.btManageusers.Text = "Manage Users";
            this.btManageusers.UseVisualStyleBackColor = false;
            this.btManageusers.Click += new System.EventHandler(this.btManageusers_Click);
            // 
            // btTestForm
            // 
            this.btTestForm.BackColor = System.Drawing.SystemColors.Control;
            this.btTestForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btTestForm.FlatAppearance.BorderSize = 2;
            this.btTestForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTestForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTestForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btTestForm.Location = new System.Drawing.Point(1214, 118);
            this.btTestForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTestForm.Name = "btTestForm";
            this.btTestForm.Size = new System.Drawing.Size(161, 46);
            this.btTestForm.TabIndex = 14;
            this.btTestForm.Text = "Test Form";
            this.btTestForm.UseVisualStyleBackColor = false;
            this.btTestForm.Click += new System.EventHandler(this.btTestForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(630, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 776);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTestForm);
            this.Controls.Add(this.btManageusers);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.exceedingSystemDataGrid);
            this.Controls.Add(this.systemComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1490, 821);
            this.MinimumSize = new System.Drawing.Size(1490, 781);
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
        private System.Windows.Forms.Button btTestForm;
        private System.Windows.Forms.Button button1;
    }
}

