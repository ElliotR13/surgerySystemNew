﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surgerySystem
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();//Close this form and open login form
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            frmConsult con = new frmConsult();//Open Consult form
            con.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmDocReport doc = new frmDocReport();//Open DocReport form
            doc.Show();
        }
    }
}
