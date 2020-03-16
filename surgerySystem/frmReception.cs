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
using System.Collections;

namespace surgerySystem
{
    public partial class frmReception : Form
    {
        DataSet dsDatabase;
        System.Data.SqlClient.SqlDataAdapter daGetData;
        public int whichRec = 0;
        public frmReception()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void MoveRecords()
        {
            DataRow OneRecord = dsDatabase.Tables["tblPatient"].Rows[whichRec];  
        }

        private void frmReception_Load(object sender, EventArgs e)
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            dsDatabase = new DataSet();

            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblPatient";//Selects all records

            daGetData = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);

            daGetData.Fill(dsDatabase, "tblPatient");
            MoveRecords();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "" || txtSurname.Text == "" || txtAddress.Text == "" || txtPCode.Text == "" || txtPhone.Text == "" || txtDOB.Text == "")
            {
                MessageBox.Show("Please ensure all fields are filled in before saving");//Prevents user from saving blank data
            }
            else
            {
                DataRow OneRecord = dsDatabase.Tables["tblPatient"].NewRow();

                OneRecord[1] = txtFirst.Text;//Adds new record, saves data using data from textboxes
                OneRecord[2] = txtSurname.Text;
                OneRecord[3] = txtAddress.Text;
                OneRecord[4] = txtPCode.Text;
                OneRecord[5] = txtPhone.Text;
                OneRecord[6] = txtDOB.Text;

                dsDatabase.Tables["tblPatient"].Rows.Add(OneRecord);

                System.Data.SqlClient.SqlCommandBuilder myUpdateDB;
                myUpdateDB = new System.Data.SqlClient.SqlCommandBuilder(daGetData);
                myUpdateDB.DataAdapter.Update(dsDatabase.Tables["tblPatient"]);

                MoveRecords();
            }
        }
    }
}
