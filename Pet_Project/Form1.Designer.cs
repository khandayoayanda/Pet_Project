namespace Pet_Project
{
    partial class Form1
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
            this.btnDonate = new System.Windows.Forms.Button();
            this.pnlType = new System.Windows.Forms.Panel();
            this.btnAdopt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(3, 12);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(147, 47);
            this.btnDonate.TabIndex = 0;
            this.btnDonate.Text = "Donate pet";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.btnAdopt);
            this.pnlType.Controls.Add(this.btnDonate);
            this.pnlType.Location = new System.Drawing.Point(75, 415);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(388, 71);
            this.pnlType.TabIndex = 3;
            // 
            // btnAdopt
            // 
            this.btnAdopt.Location = new System.Drawing.Point(220, 12);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(147, 47);
            this.btnAdopt.TabIndex = 4;
            this.btnAdopt.Text = "Adopt pet";
            this.btnAdopt.UseVisualStyleBackColor = true;
            this.btnAdopt.Click += new System.EventHandler(this.btnAdopt_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(75, 362);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(147, 47);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "Sign up";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1337, 11);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(147, 47);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 744);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.pnlType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Home page";
            this.pnlType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnLogin;
    }
}

