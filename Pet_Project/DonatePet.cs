using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Pet_Project
{
    public partial class DonatePet : Form
    {
        public DonatePet()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Firstname = txtFirstname.Text;
            string Lastname = txtLastname.Text;
            string Number = txtNumber.Text;
            string dateOfBirth = dtpBirth.Value.ToString("dd/MM/yyyy");
            string Email = txtEmail.Text;
            string Gender = "";
            string Adress = txtAddress.Text;
            string Create = txtCreate.Text;
            string Confirm = txtConfirm.Text;
            string Code = txtPostalcode.Text;

            if (radMale.Checked)
            {
                Gender = "Male";
            }
            else
                if (radFemale.Checked)
                {
                    Gender = "Female";
                }

          

            // Check if the cellphone number is empty
            if (Number == "")
            {
                MessageBox.Show(
                    "Please enter your cellphone number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNumber.Focus();
                return;
            }

            // Check for a valid South African mobile number
            // Starts with 0, followed by 6, 7, or 8,
            // followed by another 8 digits = 10 digits total
            if (!Regex.IsMatch(Number, @"^0[678]\d{8}$"))
            {
                MessageBox.Show(
                    "Please enter a valid 10-digit South African mobile number.\n\nExample: 0821234567",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }

            //Personal Email Validation
            if (!Regex.IsMatch(Email, @"^[^@\s]+@(gmail|outlook|yahoo|hotmail|icloud)\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Invalid personal email address.\nPlease enter a valid personal email (e.g., user@gmail.com or user@outlook.com).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            // 4. PHYSICAL ADDRESS VALIDATION
            if (string.IsNullOrWhiteSpace(Adress))
            {
                MessageBox.Show("Please enter the physical address.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            if (Regex.IsMatch(Adress, @"\b\d{4}\b"))
            {
                MessageBox.Show("Please enter the physical address ONLY. Do not include a 4-digit postal code in this field.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                txtAddress.SelectAll();
                return;
            }
            //postal code validation
            if (string.IsNullOrWhiteSpace(txtPostalcode.Text))
            {
                MessageBox.Show("Postal address line cannot be empty.\nPlease enter a street or box address.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPostalcode.Focus();
                return;
            }

            // 2. Validate Postal Code (4-digit format, e.g., 4001 or 0001)
            string postalCode = txtPostalcode.Text.Trim();

            if (!Regex.IsMatch(postalCode, @"^\d{4}$"))
            {
                MessageBox.Show("Invalid Postal Code.\nPlease enter a valid 4-digit postal code (e.g., 4000).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPostalcode.Focus();
                txtPostalcode.SelectAll();
                return;
            }
            //PASSWORD MATCH AND STRENGTH VALIDATION
            if (string.IsNullOrWhiteSpace(Create))
            {
                MessageBox.Show("Password cannot be empty.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }

            // Check if password has at least 8 characters
            if (Create.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }

            // Check for uppercase letter
            if (!Create.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }

            // Check for lowercase letter
            if (!Create.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }

            // Check for number
            if (!Create.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }

            // Check for special character
            if (!Create.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Password must contain at least one special character.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }

            // Confirm password
            if (Create != Confirm)
            {
                MessageBox.Show("Passwords do not match.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCreate.Focus();
                return;
            }
            StreamWriter writer = new StreamWriter(@"C:\Users\Ayanda Khandayo\Desktop\Pet.txt", true);

            using (writer)
            {
                writer.Write("Donor" + '\t' + Firstname + '\t' + Lastname + '\t' + Number + '\t' + Email + '\t' + Gender + '\t' + dateOfBirth  + '\t' + Adress + '\t' + Code + '\t' + Create + '\t' + Confirm + "\n");
            }





            txtFirstname.Clear();


            txtEmail.Clear();
            txtAddress.Clear();
            txtCreate.Clear();
            txtConfirm.Clear();
            txtPostalcode.Clear();

           

        

            MessageBox.Show("Account registered successfully", "Notification");
            this.Hide();
            Donor ss = new Donor();
            ss.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
