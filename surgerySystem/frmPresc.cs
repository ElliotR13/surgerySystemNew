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
    public partial class frmPresc : Form
    {
        int line = 1;
       // DataSet dsDatabase;
        //System.Data.SqlClient.SqlDataAdapter daGetData;
       // public int whichRec = 0;
        public frmPresc()
        {
            InitializeComponent();
        }

        private void frmPresc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'surgeryDBDataSet3.tblPrescription' table. You can move, or remove it, as needed.
            this.tblPrescriptionTableAdapter.Fill(this.surgeryDBDataSet3.tblPrescription);
            // TODO: This line of code loads data into the 'surgeryDBDataSet2.tblAppointment' table. You can move, or remove it, as needed.
            this.tblAppointmentTableAdapter.Fill(this.surgeryDBDataSet2.tblAppointment);

           /* string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            dsDatabase = new DataSet();

            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblPrescription";//Selects all records

            daGetData = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);

            daGetData.Fill(dsDatabase, "tblPrescription");
            MoveRecords();*/
        }

        private void MoveRecords()
        {
            //DataRow OneRecord = dsDatabase.Tables["tblPrescription"].Rows[whichRec];
        }

        private void MoveRecords2()
        {
            //DataRow OneRecord = dsDatabase.Tables["tblPrescLine"].Rows[whichRec];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbAppID.Text == "" || txtDiag.Text == "" || txtTreat.Text == "")
            {
                MessageBox.Show("Please ensure all fields are filled in before saving");//Prevents user from saving blank data
            }
            else
            {
                string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
                SqlConnection mySQLCon = new SqlConnection(myCon);
                mySQLCon.Open();

                SqlCommand cmUpdate = new SqlCommand();
                cmUpdate.Connection = mySQLCon;
                cmUpdate.CommandType = CommandType.Text;
                cmUpdate.CommandText = "INSERT INTO tblPrescription set appointmentID =' " + cmbAppID.Text + "', diagnosis = '" + txtDiag.Text + "', treatment = '" + txtTreat.Text + "'";
                //Updates record in seat tables that corresponds to the button that was clicked
                cmUpdate.ExecuteNonQuery();

                cmbAppID.ResetText();
                txtDiag.Clear();
                txtTreat.Clear();
                MessageBox.Show("Prescription updated");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDrug.Text == "" || cmbPresc.Text == "")
            {
                MessageBox.Show("Please ensure both fields are filled in before saving");//Prevents user from saving blank data
            }
            else
            {
                string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
                SqlConnection mySQLCon = new SqlConnection(myCon);
                mySQLCon.Open();

                SqlCommand cmUpdate = new SqlCommand();
                cmUpdate.Connection = mySQLCon;
                cmUpdate.CommandType = CommandType.Text;
                cmUpdate.CommandText = "INSERT INTO tblPrescLine set prescriptionID =' " + cmbPresc.Text + "', drugs = '" + txtDiag.Text + "', prescriptionLine = '" + line + "'";
                //Updates record in seat tables that corresponds to the button that was clicked
                cmUpdate.ExecuteNonQuery();

                MessageBox.Show("Drug added");
                txtDrug.Clear();
                line++;
            }
        }

        private void cmbPresc_SelectedIndexChanged(object sender, EventArgs e)
        {
            line = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
