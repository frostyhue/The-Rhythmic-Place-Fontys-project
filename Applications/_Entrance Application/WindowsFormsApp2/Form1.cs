using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;



namespace WindowsFormsApp2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            tbNameOrId.PromptText = "Name/Id";
            tbPassword.PromptText = "Password";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void tbNameOrId_Click(object sender, EventArgs e)
        {
            if(tbNameOrId.Text == "Name/Id")
            {
                tbNameOrId.Clear();
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {

            tbPassword.Clear();

        }

      
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbNameOrId.Clear();
            tbPassword.Clear();
        }

        private void tItems_Click(object sender, EventArgs e)
        {

        }


        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void lbPrice_Click(object sender, EventArgs e)
        {
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblConnection_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void tpRentItems_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void btnCharge_Click(object sender, EventArgs e)
        {

        }

        private void btnDeactivateAccount_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void lblClientBalance_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
