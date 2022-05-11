using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace ViewLayer
{
    public partial class UserManagerForm : Form
    {
        UserContainer userContainer;

        public static int Id;
        public static string Email;
        public static bool IsAdmin;
        private string Password = "******";

        public UserManagerForm()
        {
            InitializeComponent();
            userContainer = new UserContainer(new UserDAL());

            dgvUsers.ReadOnly = true;
            //datagridview opmaak.
            dgvUsers.ColumnCount = 4;
            dgvUsers.Columns[0].Name = "UserId";
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Name = "Email";
            dgvUsers.Columns[2].Name = "Password";
            dgvUsers.Columns[3].Name = "IsAdmin";
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Buttons toevoegen aan datagridview.
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnDelete.HeaderText = "Delete";
            btnEdit.Name = "ButtonEdit";
            btnDelete.Name = "ButtonDelete";
            btnEdit.Text = "Edit";
            btnDelete.Text = "Delete";
            btnEdit.UseColumnTextForButtonValue = true;
            btnDelete.UseColumnTextForButtonValue = true;
            dgvUsers.Columns.Add(btnEdit);
            dgvUsers.Columns.Add(btnDelete);

            FillGridView();
        }

        private void FillGridView()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Refresh();

            //datagridview vullen.
            foreach (User users in userContainer.GetAllUsers())
            {
                dgvUsers.Rows.Add(users.UserId, users.Email, Password, users.IsAdmin);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value);
            Email = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Email"].Value);
            IsAdmin = Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["IsAdmin"].Value);

            if (dgvUsers.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                UserEdit user = new UserEdit();
                user.btSaveCreate.Visible = false;
                user.btSaveEdit.Visible = true;
                user.ShowDialog();
                FillGridView();
            }

            else if (dgvUsers.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var res = MessageBox.Show("Are you sure you want to delete user", "Delete user", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    User us = new User(Id);
                    userContainer.DeleteOneAccount(us);
                    MessageBox.Show(string.Format("User with Email: {0} has been deleted", Email, "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    FillGridView();
                }
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            UserEdit user = new UserEdit();
            user.btSaveCreate.Visible = true;
            user.btSaveEdit.Visible = false;
            user.ShowDialog();
            FillGridView();
        }
    }
}
