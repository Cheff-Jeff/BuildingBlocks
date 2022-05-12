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
        BusinessLayer.System system = new BusinessLayer.System(new SystemDAL());
        SystemContainer systemContainer = new SystemContainer(new SystemDAL());

        public DBTest()
        {
            InitializeComponent();

            FillComboBox();
        }

        public void FillComboBox()
        {
            foreach(BusinessLayer.System system in systemContainer.GetAllSystems())
            {
                //var test = system.SystemId;
                //BusinessLayer.System sys = new BusinessLayer.System(test);
                //BusinessLayer.System sys1 = systemContainer.GetOneSystemNameById(sys);
                cbSystems.Items.Add(system.SystemName);
            }
        }

        private void cbSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var system = cbSystems.SelectedItem.ToString();
            BusinessLayer.System sys = new BusinessLayer.System(system);
            BusinessLayer.System sys1 = systemContainer.GetOneSystemByName(sys);
            lbSelectedId.Text = "SystemId= " + Convert.ToString(sys1.SystemId);
        }
    }
}
