using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamSupervisionSystem
{
    public partial class ExamMaster : Form
    {
        DataTable table = new DataTable("table");
        SqlConnection con;
        SqlCommand cmd,cmd1;
        SqlDataReader dr1, dr;
        SqlDataAdapter da;
        DataTable dt;
        static int eEid;

        private void btnassign_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblExam(Exam,Year,Month,Date,Time,ReportingTime) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + ExamDate.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Exam Details Added..");
                
                con.Close();
                
            }
            catch (Exception ex) { MessageBox.Show("Exam Details Added.." + ex.Message); }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExamMaster_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                con.Open();

                cmd1 = new SqlCommand("select * FROM tblYear", con);


                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    comboBox2.Items.Add(dr1["Year"].ToString());
                }
                dr1.Close();
                con.Close();
                ShowData();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("update tblExam set Exam='" + comboBox1.Text + "',Year='" + comboBox2.Text + "',Month='" + comboBox3.Text + "',Date='" + ExamDate.Text + "',Time='" + textBox1.Text + "',ReportingTime='" + textBox2.Text + "' where EID=" + Convert.ToInt32(eEid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Updated....");
                clear();
                con.Close();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            ExamDate.Text = "";
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("delete from tblExam where EID=" + Convert.ToInt32(eEid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");
                clear();
                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                eEid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                ExamDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                btnassign.Enabled = false;
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
            }
            catch (Exception ex) { }
            
        }

        public void ShowData()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from tblExam", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }




        public ExamMaster()
            {
                InitializeComponent();
            }


        }
    }

