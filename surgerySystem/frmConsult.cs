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
    public partial class frmConsult : Form
    {
        DataSet dsDatabase;
        System.Data.SqlClient.SqlDataAdapter daGetData;
        public int whichRec = 0;
        public int countRec = 0;
        public frmConsult()
        {
            InitializeComponent();
        }

        private void MoveRecords()
        {
            DataRow OneRecord = dsDatabase.Tables["tblAppointment"].Rows[whichRec];

            txtAppID.Text = OneRecord[0].ToString();
            cmbDocID.Text = OneRecord[1].ToString();//Populates textboxes with data from the table
            cmbPatID.Text = OneRecord[2].ToString();
            dtpDate.Text = OneRecord[3].ToString();
            cmbTime.Text = OneRecord[4].ToString();
        }

        private void frmConsult_Load(object sender, EventArgs e)
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            dsDatabase = new DataSet();

            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblAppointment";//Selects all records from appointment table

            daGetData = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);

            daGetData.Fill(dsDatabase, "tblAppointment");
            MoveRecords();

            countRec = dsDatabase.Tables["tblAppointment"].Rows.Count; //Sets countRec to number of records in table
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            whichRec = 0;
            MoveRecords();//Populates textboxes with data from first row
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (whichRec > 0)
            {
                whichRec--;//Subtracts one from whichRec
                MoveRecords();//Populates textboxes with data from previous row
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (whichRec < countRec - 1)//If not at last record...
            {
                whichRec++;//Add one to whichRec
                MoveRecords();//Populates textboxes with data from next row
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (whichRec < countRec - 1)//If not at last record...
            {
                whichRec = countRec - 1;//Go to last record
                MoveRecords();//Populates textboxes with data from last row
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            SqlCommand cmDelete = new SqlCommand();
            cmDelete.Connection = mySQLCon;
            cmDelete.CommandType = CommandType.Text;
            cmDelete.CommandText = "DELETE FROM tblAppointment WHERE appointmentID = '" + txtAppID.Text + "'";
            //Delete appointment that corresponds to the selected appointment ID
            cmDelete.ExecuteNonQuery();

            txtAppID.Clear();//Clear textboxes
            cmbDocID.ResetText();
            cmbPatID.ResetText();
            cmbTime.ResetText();

            MessageBox.Show("Appointment deleted");
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            SqlCommand cmArrival = new SqlCommand();
            cmArrival.Connection = mySQLCon;
            cmArrival.CommandType = CommandType.Text;
            cmArrival.CommandText = "Update tblAppointment set arrived = 'True' where appointmentID = '" + txtAppID.Text + "'";
            //Set arrived to True for the selected appointment 
            cmArrival.ExecuteNonQuery();

            MessageBox.Show("Patient registered as having arrived");
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (txtNotes.Text == "")
            {
                MessageBox.Show("Please enter text before attempting to update");//Ensures no blank data is saved
            }
            else
            {
                string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
                SqlConnection mySQLCon = new SqlConnection(myCon);
                mySQLCon.Open();

                SqlCommand cmNotes = new SqlCommand();
                cmNotes.Connection = mySQLCon;
                cmNotes.CommandType = CommandType.Text;
                cmNotes.CommandText = "Update tblPatient set notes = '" + txtNotes.Text + "' where patientID = '" + cmbPatID.Text + "'";
                //Updates patient notes based on selected ID
                cmNotes.ExecuteNonQuery();

                MessageBox.Show("Patient notes updated");
                txtNotes.Clear();//Confirms the update and clears the textbox
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();//Close form
        }

        private void btnPresc_Click(object sender, EventArgs e)
        {
            frmPresc presc = new frmPresc();//Open the prescription form
            presc.Show();
        }
    }
}
