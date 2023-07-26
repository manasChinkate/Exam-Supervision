using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            label3.Parent = panel1;
            label3.BackColor = Color.Transparent;

            label2.Parent = panel1;
            label2.BackColor = Color.Transparent;

            label1.Parent = panel1;
            label1.BackColor = Color.Transparent;

            btnHideShow.Parent = panel1;
            btnHideShow.BackColor = Color.Transparent;

            



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70, 0, 0, 0);

        }

       

       


        private void label3_Click(object sender, EventArgs e)
        {
           

        }


        private void button1_Click(object sender, EventArgs e)
        
          
            {
            

            }


        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtpassword.PasswordChar = '*';
            }
                    }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                if (txtusername.Text == "admin" && txtpassword.Text == "admin@123")
                {
                    MessageBox.Show("Login Success...");
                    MDIParent1 mm = new MDIParent1();
                    mm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Please try again?...");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
