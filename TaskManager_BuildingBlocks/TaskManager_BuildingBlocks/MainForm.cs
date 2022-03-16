using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager_BuildingBlocks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();

            if (LoggedIn.User == "") { this.Close(); return; }
            else this.Show();

            // exceedingSystemDataGrid.Rows.Add("System name", "CPU", "GPU", "RAM", "DISK", "NETWORK");
            Random random = new Random();
            for (int i = 1; i <= 2; i++)
            {

                exceedingSystemDataGrid.Rows.Add("server " + i,
                    "25%>  " + random.Next(10, 90).ToString() + "  <85%",
                    "25%>  " + random.Next(10, 90).ToString() + "  <85%",
                    "25%>  " + random.Next(10, 90).ToString() + "  <85%",
                    "25%>  " + random.Next(10, 90).ToString() + "  <85%",
                    "25%>  " + random.Next(10, 90).ToString() + "  <85%");
                exceedingSystemDataGrid.Rows[i - 1].Height += 10;
            }
        }

        private void systemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO get system ID and 
            DetailForm df = new DetailForm(systemComboBox.SelectedIndex); // change to system ID
            this.Hide();
            df.ShowDialog();
            this.Show();
        }

        private void exceedingSystemDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void exceedingSystemDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO change rowindex to invisible system ID 
            if (e.RowIndex == -1) return;
            DetailForm df = new DetailForm(e.RowIndex + 1);
            this.Hide();
            df.ShowDialog();
            this.Show();
        }
    }
}
