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
        DataSet dsDatabase, dsDatabase2;
        System.Data.SqlClient.SqlDataAdapter daGetData, daGetData2;
        public int whichRec = 0;
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

             string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
             SqlConnection mySQLCon = new SqlConnection(myCon);
             mySQLCon.Open();

             dsDatabase = new DataSet();

             String sqlGetWhat;
             sqlGetWhat = "SELECT * From tblPrescription";//Selects all records

             daGetData = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);

             daGetData.Fill(dsDatabase, "tblPrescription");
             MoveRecords();

            dsDatabase2 = new DataSet();

            String sqlGetWhat2;
            sqlGetWhat2 = "SELECT * From tblPrescLine";//Selects all records

            daGetData2 = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat2, myCon);

            daGetData2.Fill(dsDatabase2, "tblPrescLine");
            MoveRecords2();

        }

        private void MoveRecords()
        {
            DataRow OneRecord = dsDatabase.Tables["tblPrescription"].Rows[whichRec];
        }

        private void MoveRecords2()
        {
            DataRow OneRecord2 = dsDatabase2.Tables["tblPrescLine"].Rows[whichRec];
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

                DataRow OneRecord = dsDatabase.Tables["tblPrescription"].NewRow();

                OneRecord[1] = cmbAppID.Text;//Adds new record, saves data using data from textboxes
                OneRecord[2] = txtDiag.Text;
                OneRecord[3] = txtTreat.Text;

                dsDatabase.Tables["tblPrescription"].Rows.Add(OneRecord);

                System.Data.SqlClient.SqlCommandBuilder myUpdateDB;//Establish connection
                myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daGetData);
                myUpdateDB.DataAdapter.Update(dsDatabase.Tables["tblPrescription"]);

                MoveRecords();

                cmbAppID.ResetText();//Clear textboxes and confirm update
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

                DataRow OneRecord2 = dsDatabase2.Tables["tblPrescLine"].NewRow();

                OneRecord2[0] = cmbPresc.Text;//Adds new record, saves data using data from textboxes
                OneRecord2[1] = line;
                OneRecord2[2] = txtDrug.Text;

                dsDatabase2.Tables["tblPrescLine"].Rows.Add(OneRecord2);

                System.Data.SqlClient.SqlCommandBuilder myUpdateDB;//Establish connection
                myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daGetData2);
                myUpdateDB.DataAdapter.Update(dsDatabase2.Tables["tblPrescLine"]);

                MoveRecords2();

                MessageBox.Show("Drug added");//Confirm message, and clear textbox
                txtDrug.Clear();
                line++;//Adds one to line, so next drug is one more than the previous
            }
        }

        private void cmbPresc_SelectedIndexChanged(object sender, EventArgs e)
        {
            line = 1;//If a new ID is selected change line back to 1
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
