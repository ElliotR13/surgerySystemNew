using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "doctor" && txtPass.Text == "doctor1")
            {
                this.Hide();
                frmDoctor doctor = new frmDoctor();
                doctor.Show();
            }

            else if (txtUser.Text == "manager" && txtPass.Text == "manager1")
            {
                this.Hide();
                frmManager manager = new frmManager();
                manager.Show();
            }

            else if (txtUser.Text == "receptionist" && txtPass.Text == "receptionist1")
            {
                this.Hide();
                frmReception reception = new frmReception();
                reception.Show();
            }

            else
            {
                MessageBox.Show("Please enter a valid username and password to login");
            }
        }
    }
}
