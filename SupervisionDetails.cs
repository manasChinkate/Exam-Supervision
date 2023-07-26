using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ExamSupervisionSystem
{
    public partial class SupervisionDetails : Form
    {
        SqlConnection con;
        SqlCommand cmd,cmd1,cmd2;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr, dr1, dr2;
        static int esid;

        public SupervisionDetails()
        {
            InitializeComponent();
        }

        private void SupervisionDetails_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                con.Open();

                cmd = new SqlCommand("select * FROM tblFaculty", con);


                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["Fname"].ToString() + " " + dr["Mname"].ToString() + " " + dr["Lname"].ToString());
                }
                dr.Close();

                //-----------------------------------------------------------------------------------------
                cmd1 = new SqlCommand("select * FROM tblAddBlockNo", con);


                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    comboBox2.Items.Add(dr1["blockNO"].ToString());
                }
                dr1.Close();

                //---------------------------------------------------------------------------------
                cmd2 = new SqlCommand("select * FROM tblAddBlockNo", con);


                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    comboBox3.Items.Add(dr2["RoomNo"].ToString());
                }
                dr2.Close();
                con.Close();
                ShowData();
                btndelete.Enabled = false;
                btnupdate.Enabled = false;

            }
            catch (Exception ex) { }
        }

        public void ShowData()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from tblSupervision", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                esid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                btnassign.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Click left side row..");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblSupervision values('" + comboBox1.Text + "'," + Convert.ToInt32(comboBox2.Text) + "," + Convert.ToInt32(comboBox3.Text) + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Supervision Added..");
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                da = new SqlDataAdapter("select * from tblSupervision", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update tblSupervision set faculty='" + comboBox1.Text + "',blockNO='" + comboBox2.Text + "',RoomNo='" + comboBox3.Text + "' where sid=" + Convert.ToInt32(esid) + " ", con);
                cmd.ExecuteNonQuery();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from tblSupervision where sid=" + Convert.ToInt32(esid) + " ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");

                clear();
                con.Close();
                ShowData();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void clear()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

        }
    }
}
