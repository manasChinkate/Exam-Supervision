using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamSupervisionSystem
{
    public partial class AddYear : Form
    {
        SqlConnection con;
        SqlCommand cmd,cmd1;
        SqlDataAdapter da;
        DataTable dt;
        static int eyid;
        public AddYear()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {

                errorProvider1.SetError(textBox1, "Please Enter Academic Year!!");
                return;
            }
            else
            {

                errorProvider1.SetError(textBox1, String.Empty);
            }
            //------------------------------------------------------------------------------------------------------------------------
            


            if (textBox1.Text == "")
            {

                MessageBox.Show("Plz fill Details");
            }
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblYear(Year)values('" + textBox1.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Year Added..");
                textBox1.Text = "";
               
                con.Close();
                ShowData();

            }
            catch (Exception ex) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Please Enter Only Numbers");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, String.Empty);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddYears(1).AddDays(-1);
            textBox1.Text = dateTimePicker1.Value.Year + "-" + dateTimePicker2.Value.Year;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("update tblYear set Year='" + textBox1.Text + "' where YearID=" + Convert.ToInt32(eyid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Updated....");
                textBox1.Text = "";

                con.Close();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("delete from tblYear where YearID=" + Convert.ToInt32(eyid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");
                textBox1.Text = "";

                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                eyid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                bunifuFlatButton2.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Click left side row..");
            }
        }


        public void ShowData()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from tblYear order by YearID desc", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            }
            catch (Exception ex) { }

        }

        private void AddYear_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
            ShowData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
