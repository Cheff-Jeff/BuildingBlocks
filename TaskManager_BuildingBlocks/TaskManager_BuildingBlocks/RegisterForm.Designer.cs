
namespace TaskManager_BuildingBlocks
{
    partial class RegisterForm
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
            this.createUserBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rePassTxb = new System.Windows.Forms.TextBox();
            this.isAdminCbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // createUserBtn
            // 
            this.createUserBtn.BackColor = System.Drawing.SystemColors.Control;
            this.createUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.createUserBtn.FlatAppearance.BorderSize = 2;
            this.createUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.createUserBtn.Location = new System.Drawing.Point(571, 459);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(138, 40);
            this.createUserBtn.TabIndex = 10;
            this.createUserBtn.Text = "Create User";
            this.createUserBtn.UseVisualStyleBackColor = false;
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(470, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // passTxb
            // 
            this.passTxb.BackColor = System.Drawing.Color.White;
            this.passTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.passTxb.Location = new System.Drawing.Point(475, 289);
            this.passTxb.Name = "passTxb";
            this.passTxb.Size = new System.Drawing.Size(320, 32);
            this.passTxb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(470, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // emailTxb
            // 
            this.emailTxb.BackColor = System.Drawing.Color.White;
            this.emailTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.emailTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.emailTxb.Location = new System.Drawing.Point(475, 210);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(320, 32);
            this.emailTxb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(470, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Retype password";
            // 
            // rePassTxb
            // 
            this.rePassTxb.BackColor = System.Drawing.Color.White;
            this.rePassTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rePassTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.rePassTxb.Location = new System.Drawing.Point(475, 364);
            this.rePassTxb.Name = "rePassTxb";
            this.rePassTxb.Size = new System.Drawing.Size(320, 32);
            this.rePassTxb.TabIndex = 11;
            // 
            // isAdminCbx
            // 
            this.isAdminCbx.AutoSize = true;
            this.isAdminCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.isAdminCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.isAdminCbx.Location = new System.Drawing.Point(581, 414);
            this.isAdminCbx.Name = "isAdminCbx";
            this.isAdminCbx.Size = new System.Drawing.Size(117, 30);
            this.isAdminCbx.TabIndex = 13;
            this.isAdminCbx.Text = "Is Admin";
            this.isAdminCbx.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.isAdminCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rePassTxb);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTxb);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUserBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rePassTxb;
        private System.Windows.Forms.CheckBox isAdminCbx;
    }
}