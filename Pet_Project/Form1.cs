using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlType.Visible = false;

        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonatePet ss = new DonatePet();
            ss.Show();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            pnlType.Visible=true;
        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdoptPet ss = new AdoptPet();
            ss.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }
    }
}
