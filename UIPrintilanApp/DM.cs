﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    public partial class DM : Form
    {
        public DM()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDM ListDMForm = new ListDM();
            ListDMForm.Show();
        }

        private void DM_Load(object sender, EventArgs e)
        {

        }
    }
}
