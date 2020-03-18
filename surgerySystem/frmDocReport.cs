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
    public partial class frmDocReport : Form
    {
        public frmDocReport()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbID.Text == "")
            {
                MessageBox.Show("Please select an ID");
            }

            else
            {
                DataSet dsApps = new DataSet();

                string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
                SqlConnection mySQLCon = new SqlConnection(myCon);
                mySQLCon.Open();

                SqlCommand cmApps = new SqlCommand();
                cmApps.Connection = mySQLCon;
                cmApps.CommandType = CommandType.Text;
                cmApps.CommandText = "Select * from tblAppointment where doctorID = " + cmbID.Text;
                SqlDataAdapter daApps = new SqlDataAdapter(cmApps);

                daApps.Fill(dsApps);
                mySQLCon.Close();

                appointmentGrid.DataSource = dsApps.Tables[0];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
