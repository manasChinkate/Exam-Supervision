﻿using System;
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
    public partial class welocme : Form
    {
        public welocme()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value==10)
            {
                label2.Text= "Project Loading...";
            }
            if (progressBar1.Value == 50)
            {
                label2.Text= "Project starting...";
            }
            if (progressBar1.Value == 80)
            {
                label2.Text="Login Loading...";
            }
            if (progressBar1.Value == 100)
            {
                label2.Text = "loading succesfull";
                progressBar1.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
