using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSupervisionSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {

                errorProvider1.SetError(txtusername, "Please Enter usename!!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtusername, String.Empty);
            }
 //------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {

                errorProvider2.SetError(txtpassword, "Please Enter Password !");
                return;
            }
            else
            {

                errorProvider2.SetError(txtpassword, String.Empty);
            }








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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(70, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70, 0, 0, 0);
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Parent = panel1;
            label3.BackColor = Color.Transparent;

            label2.Parent = panel1;
            label2.BackColor = Color.Transparent;

            label1.Parent = panel1;
            label1.BackColor = Color.Transparent;

            button6.Parent = panel2;
            button6.BackColor = Color.Transparent;

            button4.Parent = panel2;
            button4.BackColor = Color.Transparent;

            maximize.Parent = panel2;
            maximize.BackColor = Color.Transparent;

            label5.Parent = panel2;
            label5.BackColor = Color.Transparent;

            
            


            
           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            

            if (WindowState == FormWindowState.Normal) 
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal;
            }


        }
        

        

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
    }

