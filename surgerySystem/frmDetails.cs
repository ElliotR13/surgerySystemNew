using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace surgerySystem
{
    public partial class frmDetails : Form
    {
        DataSet dsDatabase;
        System.Data.SqlClient.SqlDataAdapter daGetData;
        public int whichRec = 0;
        public int countRec = 0;
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            string myCon = ConfigurationManager.ConnectionStrings["SurgeryConnString"].ConnectionString;
            SqlConnection mySQLCon = new SqlConnection(myCon);
            mySQLCon.Open();

            dsDatabase = new DataSet();

            String sqlGetWhat;
            sqlGetWhat = "SELECT * From tblPatient";//Selects all records from Patient table

            daGetData = new System.Data.SqlClient.SqlDataAdapter(sqlGetWhat, myCon);

            daGetData.Fill(dsDatabase, "tblPatient");
            MoveRecords();

            countRec = dsDatabase.Tables["tblPatient"].Rows.Count; //Sets countRec to number of records in table
        }

        private void MoveRecords()
        {
            DataRow OneRecord = dsDatabase.Tables["tblPatient"].Rows[whichRec];

            txtID.Text = OneRecord[0].ToString();//Populates textboxes with data from the table
            txtFirst.Text = OneRecord[1].ToString();
            txtSurname.Text = OneRecord[2].ToString();
            txtAddress.Text = OneRecord[3].ToString();
            txtPCode.Text = OneRecord[4].ToString();
            txtPhone.Text = OneRecord[5].ToString();
            txtDOB.Text = OneRecord[6].ToString();
            txtNotes.Text = OneRecord[7].ToString();
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
    }
}
