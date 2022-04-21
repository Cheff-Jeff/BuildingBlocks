
namespace ViewLayer
{
    partial class UserEdit
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
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveEdit = new System.Windows.Forms.Button();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.tbRetypepassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rbIsadmin = new System.Windows.Forms.RadioButton();
            this.btSaveCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(342, 229);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 31);
            this.btExit.TabIndex = 76;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(102, 229);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(114, 31);
            this.btCancel.TabIndex = 75;
            this.btCancel.Text = "Clear";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSaveEdit
            // 
            this.btSaveEdit.Location = new System.Drawing.Point(222, 230);
            this.btSaveEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveEdit.Name = "btSaveEdit";
            this.btSaveEdit.Size = new System.Drawing.Size(114, 31);
            this.btSaveEdit.TabIndex = 74;
            this.btSaveEdit.Text = "Save";
            this.btSaveEdit.UseVisualStyleBackColor = true;
            this.btSaveEdit.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Location = new System.Drawing.Point(15, 109);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(125, 20);
            this.lbAdress.TabIndex = 69;
            this.lbAdress.Text = "Retype password:";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(15, 63);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(73, 20);
            this.lbLastname.TabIndex = 68;
            this.lbLastname.Text = "Password:";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Location = new System.Drawing.Point(15, 16);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(49, 20);
            this.lbFirstname.TabIndex = 67;
            this.lbFirstname.Text = "Email:";
            // 
            // tbRetypepassword
            // 
            this.tbRetypepassword.Location = new System.Drawing.Point(140, 109);
            this.tbRetypepassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRetypepassword.Name = "tbRetypepassword";
            this.tbRetypepassword.Size = new System.Drawing.Size(296, 27);
            this.tbRetypepassword.TabIndex = 64;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(140, 63);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(296, 27);
            this.tbPassword.TabIndex = 63;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(140, 16);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(296, 27);
            this.tbEmail.TabIndex = 62;
            // 
            // rbIsadmin
            // 
            this.rbIsadmin.AutoSize = true;
            this.rbIsadmin.Location = new System.Drawing.Point(234, 164);
            this.rbIsadmin.Name = "rbIsadmin";
            this.rbIsadmin.Size = new System.Drawing.Size(84, 24);
            this.rbIsadmin.TabIndex = 77;
            this.rbIsadmin.TabStop = true;
            this.rbIsadmin.Text = "IsAdmin";
            this.rbIsadmin.UseVisualStyleBackColor = true;
            // 
            // btSaveCreate
            // 
            this.btSaveCreate.Location = new System.Drawing.Point(222, 229);
            this.btSaveCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSaveCreate.Name = "btSaveCreate";
            this.btSaveCreate.Size = new System.Drawing.Size(114, 31);
            this.btSaveCreate.TabIndex = 78;
            this.btSaveCreate.Text = "Save";
            this.btSaveCreate.UseVisualStyleBackColor = true;
            this.btSaveCreate.Click += new System.EventHandler(this.btSaveCreate_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 281);
            this.Controls.Add(this.btSaveCreate);
            this.Controls.Add(this.rbIsadmin);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSaveEdit);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbFirstname);
            this.Controls.Add(this.tbRetypepassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.Button btSaveEdit;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.TextBox tbRetypepassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RadioButton rbIsadmin;
        public System.Windows.Forms.Button btSaveCreate;
    }
}