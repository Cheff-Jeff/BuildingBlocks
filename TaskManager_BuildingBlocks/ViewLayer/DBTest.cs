using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer
{
    public partial class DBTest : Form
    {
        BusinessLayer.Server system = new BusinessLayer.Server(new ServerDAL());
        ServerContainer systemContainer = new ServerContainer(new ServerDAL());

        public DBTest()
        {
            InitializeComponent();

            FillComboBox();
        }

        public void FillComboBox()
        {
            foreach(BusinessLayer.Server system in systemContainer.GetAllSystems())
            {
                //var test = system.SystemId;
                //BusinessLayer.System sys = new BusinessLayer.System(test);
                //BusinessLayer.System sys1 = systemContainer.GetOneSystemNameById(sys);
                cbSystems.Items.Add(system.ServerName);
            }
        }

        private void cbSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var system = cbSystems.SelectedItem.ToString();
            BusinessLayer.Server sys = new BusinessLayer.Server(system);
            BusinessLayer.Server sys1 = systemContainer.GetOneSystemByName(sys);
            lbSelectedId.Text = "SystemId= " + Convert.ToString(sys1.ServerId);
        }
    }
}
