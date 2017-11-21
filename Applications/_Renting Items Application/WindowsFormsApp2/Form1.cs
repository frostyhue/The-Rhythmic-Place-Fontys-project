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

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SetAutoScrollMargins()
        {
            /* If the text box is outside the panel's bounds, 
               turn on auto-scrolling and set the margin. */
            if (button3.Location.X > panel1.Location.X ||
               button3.Location.Y > panel1.Location.Y)
            {
                panel1.AutoScroll = true;
                /* If the AutoScrollMargin is set to less 
                   than (5,5), set it to 5,5. */
                if (panel1.AutoScrollMargin.Width < 5 ||
                   panel1.AutoScrollMargin.Height < 5)
                {
                    panel1.SetAutoScrollMargin(5, 5);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
