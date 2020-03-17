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
    public partial class frmAppointment : Form
    {
        DataSet dsDatabase;
        System.Data.SqlClient.SqlDataAdapter daGetData;
        public int whichRec = 0;
        public int countRec = 0;
        public frmAppointment()
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

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'surgeryDBDataSet1.tblPatient' table. You can move, or remove it, as needed.
            this.tblPatientTableAdapter.Fill(this.surgeryDBDataSet1.tblPatient);
            // TODO: This line of code loads data into the 'surgeryDBDataSet.tblDoctor' table. You can move, or remove it, as needed.
            this.tblDoctorTableAdapter.Fill(this.surgeryDBDataSet.tblDoctor);

            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            dsDatabase = new DataSet();

            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblAppointment";//Selects all records from Patient table

            daGetData = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);

            daGetData.Fill(dsDatabase, "tblAppointment");
            MoveRecords();

            countRec = dsDatabase.Tables["tblAppointment"].Rows.Count; //Sets countRec to number of records in table
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            whichRec = 0;
            MoveRecords();//Populates textboxes with data from first row

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (whichRec > 0)
            {
                whichRec--;//Subtracts one from whichRec
                MoveRecords();//Populates textboxes with data from previous row

                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (whichRec < countRec - 1)//If not at last record...
            {
                whichRec++;//Add one to whichRec
                MoveRecords();//Populates textboxes with data from next row

                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (whichRec < countRec - 1)//If not at last record...
            {
                whichRec = countRec - 1;//Go to last record
                MoveRecords();//Populates textboxes with data from last row

                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;

            txtAppID.Clear();
            cmbDocID.ResetText();
            cmbPatID.ResetText();
            cmbTime.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDocID.Text == "" || cmbPatID.Text == "" || cmbTime.Text == "")
            {
                MessageBox.Show("Please ensure all fields are filled in before saving");//Prevents user from saving blank data
            }
            else
            {
                DataRow OneRecord = dsDatabase.Tables["tblAppointment"].NewRow();

                OneRecord[1] = cmbDocID.Text;//Adds new record, saves data using data from textboxes
                OneRecord[2] = cmbPatID.Text;
                OneRecord[3] = dtpDate.Text;
                OneRecord[4] = cmbTime.Text;
                OneRecord[5] = "False";

                dsDatabase.Tables["tblAppointment"].Rows.Add(OneRecord);

                System.Data.SqlClient.SqlCommandBuilder myUpdateDB;
                myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daGetData);
                myUpdateDB.DataAdapter.Update(dsDatabase.Tables["tblAppointment"]);

                MoveRecords();

                cmbDocID.ResetText();
                cmbPatID.ResetText();
                cmbTime.ResetText();

                MessageBox.Show("Appointment Added");

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            SqlCommand cmUpdate = new SqlCommand();
            cmUpdate.Connection = mySQLCon;
            cmUpdate.CommandType = CommandType.Text;
            cmUpdate.CommandText = "Update tblAppointment set doctorID =' " + cmbDocID.Text + "', date = '" + dtpDate.Value.Date.ToString("yyyyMMdd") + "', time = '" + cmbTime.Text + "' where appointmentID = '" + txtAppID.Text + "'";
            //Updates record in seat tables that corresponds to the button that was clicked
            cmUpdate.ExecuteNonQuery();
        }
    }
}
