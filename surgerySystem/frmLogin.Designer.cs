﻿namespace surgerySystem
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(199, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 71);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(213, 91);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(164, 22);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(213, 167);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 22);
            this.txtPass.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(76, 91);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 17);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(80, 172);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 17);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
    }
}

