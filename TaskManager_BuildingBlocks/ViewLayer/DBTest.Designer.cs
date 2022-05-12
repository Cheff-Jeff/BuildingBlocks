
namespace ViewLayer
{
    partial class DBTest
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
            this.cbSystems = new System.Windows.Forms.ComboBox();
            this.lbSelectedId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSystems
            // 
            this.cbSystems.FormattingEnabled = true;
            this.cbSystems.Location = new System.Drawing.Point(31, 25);
            this.cbSystems.Name = "cbSystems";
            this.cbSystems.Size = new System.Drawing.Size(151, 28);
            this.cbSystems.TabIndex = 0;
            this.cbSystems.SelectedIndexChanged += new System.EventHandler(this.cbSystems_SelectedIndexChanged);
            // 
            // lbSelectedId
            // 
            this.lbSelectedId.AutoSize = true;
            this.lbSelectedId.Location = new System.Drawing.Point(188, 28);
            this.lbSelectedId.Name = "lbSelectedId";
            this.lbSelectedId.Size = new System.Drawing.Size(50, 20);
            this.lbSelectedId.TabIndex = 1;
            this.lbSelectedId.Text = "label1";
            // 
            // DBTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSelectedId);
            this.Controls.Add(this.cbSystems);
            this.Name = "DBTest";
            this.Text = "DBTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSystems;
        private System.Windows.Forms.Label lbSelectedId;
    }
}