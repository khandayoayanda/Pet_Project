namespace Pet_Project
{
    partial class DonatePet
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.txtPostalcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(368, 428);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(191, 33);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(610, 41);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(262, 30);
            this.txtLastname.TabIndex = 2;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(195, 215);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(80, 29);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(195, 107);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(373, 30);
            this.dtpBirth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.radFemale);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCreate);
            this.panel1.Controls.Add(this.txtPostalcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpBirth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(177, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 552);
            this.panel1.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(98, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 40);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(14, 473);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(337, 54);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Already have an account? Click here to Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(298, 215);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(104, 29);
            this.radFemale.TabIndex = 22;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gender:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(677, 373);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(263, 30);
            this.txtConfirm.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Confirm Password:";
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(195, 368);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(262, 30);
            this.txtCreate.TabIndex = 18;
            // 
            // txtPostalcode
            // 
            this.txtPostalcode.Location = new System.Drawing.Point(677, 315);
            this.txtPostalcode.Name = "txtPostalcode";
            this.txtPostalcode.Size = new System.Drawing.Size(126, 30);
            this.txtPostalcode.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Postal code:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 317);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 30);
            this.txtAddress.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Physical Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 30);
            this.txtEmail.TabIndex = 13;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(195, 264);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(262, 30);
            this.txtNumber.TabIndex = 12;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(195, 46);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(233, 30);
            this.txtFirstname.TabIndex = 11;
            // 
            // DonatePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 703);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DonatePet";
            this.Text = "DonatePet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtPostalcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}