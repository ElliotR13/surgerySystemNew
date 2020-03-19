namespace surgerySystem
{
    partial class frmPresc
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAppID = new System.Windows.Forms.ComboBox();
            this.tblAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surgeryDBDataSet2 = new surgerySystem.surgeryDBDataSet2();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surgeryDBDataSet = new surgerySystem.surgeryDBDataSet();
            this.surgeryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentTableAdapter = new surgerySystem.surgeryDBDataSet2TableAdapters.tblAppointmentTableAdapter();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.txtTreat = new System.Windows.Forms.TextBox();
            this.txtDrug = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPresc = new System.Windows.Forms.ComboBox();
            this.tblPrescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surgeryDBDataSet3 = new surgerySystem.surgeryDBDataSet3();
            this.tblPrescriptionTableAdapter = new surgerySystem.surgeryDBDataSet3TableAdapters.tblPrescriptionTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(262, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 56);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update Prescription";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 65;
            this.label5.Text = "Appointment ID:";
            // 
            // cmbAppID
            // 
            this.cmbAppID.DataSource = this.tblAppointmentBindingSource;
            this.cmbAppID.DisplayMember = "appointmentID";
            this.cmbAppID.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppID.FormattingEnabled = true;
            this.cmbAppID.Location = new System.Drawing.Point(240, 45);
            this.cmbAppID.Name = "cmbAppID";
            this.cmbAppID.Size = new System.Drawing.Size(131, 36);
            this.cmbAppID.TabIndex = 63;
            // 
            // tblAppointmentBindingSource
            // 
            this.tblAppointmentBindingSource.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource.DataSource = this.surgeryDBDataSet2;
            // 
            // surgeryDBDataSet2
            // 
            this.surgeryDBDataSet2.DataSetName = "surgeryDBDataSet2";
            this.surgeryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "Diagnosis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Treatment:";
            // 
            // surgeryDBDataSet
            // 
            this.surgeryDBDataSet.DataSetName = "surgeryDBDataSet";
            this.surgeryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surgeryDBDataSetBindingSource
            // 
            this.surgeryDBDataSetBindingSource.DataSource = this.surgeryDBDataSet;
            this.surgeryDBDataSetBindingSource.Position = 0;
            // 
            // tblAppointmentTableAdapter
            // 
            this.tblAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // txtDiag
            // 
            this.txtDiag.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiag.Location = new System.Drawing.Point(193, 117);
            this.txtDiag.Multiline = true;
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(262, 80);
            this.txtDiag.TabIndex = 68;
            // 
            // txtTreat
            // 
            this.txtTreat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreat.Location = new System.Drawing.Point(193, 229);
            this.txtTreat.Multiline = true;
            this.txtTreat.Name = "txtTreat";
            this.txtTreat.Size = new System.Drawing.Size(262, 80);
            this.txtTreat.TabIndex = 69;
            // 
            // txtDrug
            // 
            this.txtDrug.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrug.Location = new System.Drawing.Point(512, 229);
            this.txtDrug.Multiline = true;
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(262, 80);
            this.txtDrug.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "Drugs:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(559, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 56);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Add Drugs";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 74;
            this.label3.Text = "Prescription ID:";
            // 
            // cmbPresc
            // 
            this.cmbPresc.DataSource = this.tblPrescriptionBindingSource;
            this.cmbPresc.DisplayMember = "prescriptionID";
            this.cmbPresc.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPresc.FormattingEnabled = true;
            this.cmbPresc.Location = new System.Drawing.Point(579, 93);
            this.cmbPresc.Name = "cmbPresc";
            this.cmbPresc.Size = new System.Drawing.Size(131, 36);
            this.cmbPresc.TabIndex = 73;
            this.cmbPresc.SelectedIndexChanged += new System.EventHandler(this.cmbPresc_SelectedIndexChanged);
            // 
            // tblPrescriptionBindingSource
            // 
            this.tblPrescriptionBindingSource.DataMember = "tblPrescription";
            this.tblPrescriptionBindingSource.DataSource = this.surgeryDBDataSet3;
            // 
            // surgeryDBDataSet3
            // 
            this.surgeryDBDataSet3.DataSetName = "surgeryDBDataSet3";
            this.surgeryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPrescriptionTableAdapter
            // 
            this.tblPrescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 56);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPresc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPresc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDrug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTreat);
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAppID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmPresc";
            this.Text = "frmPresc";
            this.Load += new System.EventHandler(this.frmPresc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surgeryDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAppID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource surgeryDBDataSetBindingSource;
        private surgeryDBDataSet surgeryDBDataSet;
        private surgeryDBDataSet2 surgeryDBDataSet2;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource;
        private surgeryDBDataSet2TableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.TextBox txtTreat;
        private System.Windows.Forms.TextBox txtDrug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPresc;
        private surgeryDBDataSet3 surgeryDBDataSet3;
        private System.Windows.Forms.BindingSource tblPrescriptionBindingSource;
        private surgeryDBDataSet3TableAdapters.tblPrescriptionTableAdapter tblPrescriptionTableAdapter;
        private System.Windows.Forms.Button btnBack;
    }
}