﻿using System;
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
    public partial class DetailForm : Form
    {
        public DetailForm(int systemId)
        {
            InitializeComponent();
            MessageBox.Show("systemId = " + systemId);
        }
    }
}
