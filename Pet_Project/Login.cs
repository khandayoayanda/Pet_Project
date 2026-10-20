using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(
 @"C:\Users\Ayanda Khandayo\Desktop\Pet.txt"
);

            string[] Array = new string[12];

            string lineRec = "";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool login = false;
            string userType = "";

            using (reader)
            {
                lineRec = reader.ReadLine();

                while (lineRec != null)
                {
                    Array = lineRec.Split('\t');

                    // Check Organization Donor or Apply for Donation
                    if (Array[0] == "Adopt")
                       
                    {
                        if (username == Array[4] && password == Array[9])
                        {
                            login = true;
                            userType = Array[0];
                            break;
                        }
                    }

                    // Check Individual Donor
                    else if (Array[0] == "Donor")
                    {
                        if (username == Array[4] && password == Array[9])
                        {
                            login = true;
                            userType = Array[0];
                            break;
                        }
                    }

                    lineRec = reader.ReadLine();
                }
            }

            if (login)
            {
                MessageBox.Show("Login Successfully", "Notification");

                // Open the correct form depending on user type
                if (userType == "Donor")
                {
                    this.Hide();

                    Donor ss = new Donor();
                    ss.Show();
                }
                else if (userType == "Adopt") 
                {
                    this.Hide();

                    Adopt ss = new Adopt();
                    ss.Show();
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password. Please try again.",
                    "Notification"
                );
            }

            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
