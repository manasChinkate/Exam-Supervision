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
using System.Configuration;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ExamSupervisionSystem
{
    public partial class MemberMst : Form
    {
        DataTable table = new DataTable("Newtable");
        SqlConnection con;
        SqlCommand cmd, cmd1, cmd2;
        SqlDataReader dr1, dr;
        DataTable dt;
        static int emid;


        private void btnaddmember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmember.Text.Trim()))
            {

                errorProvider1.SetError(txtmember, "Please Enter Member Name!!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtmember, String.Empty);
            }
            //------------------------------------------------------------------------------------------------------------------------
            if (txtcontact.Text.Length!=10 )
                
            {
                errorProvider2.SetError(txtcontact, "PLease Enter Valid Phone Number");
                return;

            }
            else
            {
                errorProvider2.SetError(txtcontact, String.Empty);

            }
//------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {

                errorProvider2.SetError(txtemail, "Please Enter Email Address !");
                return;
            }
            else
            {

                errorProvider2.SetError(txtemail, String.Empty);
            }
//------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {

                errorProvider2.SetError(comboBox1, "Please Select Department Name !");
                return;
            }
            else
            {

                errorProvider2.SetError(comboBox1, String.Empty);
            }
//------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtrole.Text.Trim()))
            {

                errorProvider2.SetError(txtrole, "Please Enter Role !");
                return;
            }
            else
            {

                errorProvider2.SetError(txtrole, String.Empty);
            }


            //------------------------------------------------------------------------------------------------------------------------
            


            //------------------------------------------------------------------------------------------------------------------------
            if (txtmember.Text == "" || txtcontact.Text == "" || txtemail.Text == "" || txtrole.Text == ""  || comboBox1.Text == "" )
            {

                MessageBox.Show("Plz fill Details");
                //txtemail.Focus();

            }
//------------------------------------------------------------------------------------------------------------------------
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblMember(member_name,contact,emailid,deptname,role) values('" + txtmember.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + comboBox1.Text + "','" + txtrole.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Faculty Added..");
                txtmember.Text = "";
                txtcontact.Text = "";
                txtemail.Text = "";
                txtrole.Text = "";

                comboBox1.Text = "";
                
                da = new SqlDataAdapter("select * from tblMember", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show("Faculty Added.." + ex.Message); }
           
        }
//------------------------------------------------------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            comboBox1.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtmember.Text = "";
            txtrole.Text = "";
        }  

        //------------------------------------------------------------------------------------------------------------------------

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("delete from tblmember where mid=" + Convert.ToInt32(emid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");
                

                con.Close();
                ShowData();
                    clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(txtcontact, "Please Enter Valid Phone Number");
                return;
            }
            else
            {
                errorProvider2.SetError(txtcontact, String.Empty);
            }
        }

        private void txtmember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtmember, "Please Enter Member Name!!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtmember, String.Empty);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("update tblmember set member_name='" + txtmember.Text + "',contact='" + txtcontact.Text + "',emailid='" + txtemail.Text + "',deptname='" + comboBox1.Text + "',role='" + txtrole.Text + "' where mid=" + Convert.ToInt32(emid) + " ", con);
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



        //------------------------------------------------------------------------------------------------------------------------

        SqlDataAdapter da;

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                emid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                txtmember.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtcontact.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtrole.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                btnaddmember.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Click left side row..");
            }
        }

        public MemberMst()
        {
            InitializeComponent();
        }

        private void MemberMst_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                con.Open();

                cmd1 = new SqlCommand("select * FROM tblDept", con);


                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    comboBox1.Items.Add(dr1["Dname"].ToString());
                }
                dr1.Close();
                


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
                    da = new SqlDataAdapter("select * from tblmember", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Show();
                    con.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
                
            
        }
    }

