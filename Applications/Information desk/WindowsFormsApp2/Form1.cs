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
    public partial class Help_desk : MetroForm
    {
        public Help_desk()
        {
            InitializeComponent();
            tbNameOrId.PromptText = "Name/Id";
            tbPassword.PromptText = "Password";
            panel3.Hide();
            label5.Hide();
            textBox1.Hide();
            button3.Hide();
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

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "")
            {
                MessageBox.Show("not found");
                panel3.Hide();
                label5.Hide();
                textBox1.Hide();
                button3.Hide();
            }
            else
            {
                MessageBox.Show("Account found");
                panel3.Show();
                label5.Show();
                textBox1.Show();
               
            }
    

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Everything has been saved :-)");
            panel3.Hide();
            label5.Hide();
            textBox1.Hide();
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Show();
        }
    }
}
