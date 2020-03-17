namespace surgerySystem
{
    partial class frmAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbDocID = new System.Windows.Forms.ComboBox();
            this.cmbPatID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.surgeryDBDataSet = new surgerySystem.surgeryDBDataSet();
            this.tblDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDoctorTableAdapter = new surgerySystem.surgeryDBDataSetTableAdapters.tblDoctorTableAdapter();
            this.surgeryDBDataSet1 = new surgerySystem.surgeryDBDataSet1();
            this.tblPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPatientTableAdapter = new surgerySystem.surgeryDBDataSet1TableAdapters.tblPatientTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(622, 485);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(127, 56);
            this.btnLast.TabIndex = 51;
            this.btnLast.Text = "Last Record";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(239, 485);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(127, 56);
            this.btnPrev.TabIndex = 50;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(432, 485);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(127, 56);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(53, 485);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(127, 56);
            this.btnFirst.TabIndex = 48;
            this.btnFirst.Text = "First Record";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "Doctor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Patient ID:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(283, 202);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(298, 36);
            this.dtpDate.TabIndex = 52;
            // 
            // cmbTime
            // 
            this.cmbTime.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.cmbTime.Location = new System.Drawing.Point(283, 274);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(189, 36);
            this.cmbTime.TabIndex = 53;
            // 
            // cmbDocID
            // 
            this.cmbDocID.DataSource = this.tblDoctorBindingSource;
            this.cmbDocID.DisplayMember = "doctorID";
            this.cmbDocID.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocID.FormattingEnabled = true;
            this.cmbDocID.Location = new System.Drawing.Point(283, 67);
            this.cmbDocID.Name = "cmbDocID";
            this.cmbDocID.Size = new System.Drawing.Size(131, 36);
            this.cmbDocID.TabIndex = 54;
            // 
            // cmbPatID
            // 
            this.cmbPatID.DataSource = this.tblPatientBindingSource;
            this.cmbPatID.DisplayMember = "patientID";
            this.cmbPatID.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatID.FormattingEnabled = true;
            this.cmbPatID.Location = new System.Drawing.Point(283, 130);
            this.cmbPatID.Name = "cmbPatID";
            this.cmbPatID.Size = new System.Drawing.Size(131, 36);
            this.cmbPatID.TabIndex = 55;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(485, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 56);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save New Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(174, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 56);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add New Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // surgeryDBDataSet
            // 
            this.surgeryDBDataSet.DataSetName = "surgeryDBDataSet";
            this.surgeryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoctorBindingSource
            // 
            this.tblDoctorBindingSource.DataMember = "tblDoctor";
            this.tblDoctorBindingSource.DataSource = this.surgeryDBDataSet;
            // 
            // tblDoctorTableAdapter
            // 
            this.tblDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // surgeryDBDataSet1
            // 
            this.surgeryDBDataSet1.DataSetName = "surgeryDBDataSet1";
            this.surgeryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPatientBindingSource
            // 
            this.tblPatientBindingSource.DataMember = "tblPatient";
            this.tblPatientBindingSource.DataSource = this.surgeryDBDataSet1;
            // 
            // tblPatientTableAdapter
            // 
            this.tblPatientTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Appointment ID:";
            // 
            // txtAppID
            // 
            this.txtAppID.Enabled = false;
            this.txtAppID.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppID.Location = new System.Drawing.Point(283, 12);
            this.txtAppID.MaxLength = 8;
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(131, 36);
            this.txtAppID.TabIndex = 59;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(321, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 56);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "Update Current Appointment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 557);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPatID);
            this.Controls.Add(this.cmbDocID);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAppointment";
            this.Text = "frmAppointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbDocID;
        private System.Windows.Forms.ComboBox cmbPatID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private surgeryDBDataSet surgeryDBDataSet;
        private System.Windows.Forms.BindingSource tblDoctorBindingSource;
        private surgeryDBDataSetTableAdapters.tblDoctorTableAdapter tblDoctorTableAdapter;
        private surgeryDBDataSet1 surgeryDBDataSet1;
        private System.Windows.Forms.BindingSource tblPatientBindingSource;
        private surgeryDBDataSet1TableAdapters.tblPatientTableAdapter tblPatientTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Button btnUpdate;
    }
}