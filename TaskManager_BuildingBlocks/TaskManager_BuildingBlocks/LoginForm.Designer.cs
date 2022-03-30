
namespace TaskManager_BuildingBlocks
{
    partial class LoginForm
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
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.skipLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTxb
            // 
            this.emailTxb.BackColor = System.Drawing.Color.White;
            this.emailTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.emailTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.emailTxb.Location = new System.Drawing.Point(480, 237);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(320, 32);
            this.emailTxb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(475, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(475, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTxb
            // 
            this.passwordTxb.BackColor = System.Drawing.Color.White;
            this.passwordTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordTxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.passwordTxb.Location = new System.Drawing.Point(480, 322);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.Size = new System.Drawing.Size(320, 32);
            this.passwordTxb.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.loginBtn.Location = new System.Drawing.Point(590, 380);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 40);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // skipLoginBtn
            // 
            this.skipLoginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.skipLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.skipLoginBtn.FlatAppearance.BorderSize = 2;
            this.skipLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.skipLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.skipLoginBtn.Location = new System.Drawing.Point(590, 435);
            this.skipLoginBtn.Name = "skipLoginBtn";
            this.skipLoginBtn.Size = new System.Drawing.Size(100, 40);
            this.skipLoginBtn.TabIndex = 5;
            this.skipLoginBtn.Text = "Skip login";
            this.skipLoginBtn.UseVisualStyleBackColor = false;
            this.skipLoginBtn.Click += new System.EventHandler(this.skipLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.skipLoginBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTxb);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button skipLoginBtn;
    }
}