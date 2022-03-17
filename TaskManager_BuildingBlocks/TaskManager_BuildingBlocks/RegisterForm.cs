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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser();
            this.Close();
        }

        private void CreateUser()
        {
            string email = emailTxb.Text;
            string password = passTxb.Text;
            string rePass = rePassTxb.Text;
            bool isAdmin = isAdminCbx.Checked;

            if (password != rePass) { MessageBox.Show("Passwords do not match"); return; }

            /// TODO check if email exist
            ///     Add user to DB
        }
    }
}
