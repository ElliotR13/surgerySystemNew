using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace surgerySystem
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();//Close this form and open login form
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmDetails det = new frmDetails();//Open details form
            det.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet dsApps = new DataSet();

            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            SqlCommand cmApps = new SqlCommand();
            cmApps.Connection = mySQLCon;
            cmApps.CommandType = CommandType.Text;
            cmApps.CommandText = "Select * from tblAppointment";
            SqlDataAdapter daApps = new SqlDataAdapter(cmApps);
            //Select all booked appointments
            daApps.Fill(dsApps);
            mySQLCon.Close();

            appointmentGrid.DataSource = dsApps.Tables[0];
        }
    }
}
