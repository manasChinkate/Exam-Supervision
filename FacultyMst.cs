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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamSupervisionSystem
{
    public partial class FacultyMst : Form
    {
        DataTable table= new DataTable("table");
        SqlConnection con;
        SqlCommand cmd,cmd1,cmd2;
        SqlDataReader dr1, dr;
        SqlDataAdapter da;
        DataTable dt;
        static int efid;
        private void FacultyMst_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                con.Open();

                cmd2 = new SqlCommand("select * FROM tblYear", con);

                dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["Year"].ToString());
                }
                dr.Close();


                cmd1 = new SqlCommand("select * FROM tblDept", con);


                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    comboBox1.Items.Add(dr1["Dname"].ToString());
                }
                dr1.Close();


                con.Close();
                ShowData();
                button2.Enabled = false;
                button3.Enabled = false;
            }
            catch (Exception ex) { }
        }

        public void ShowData()
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from tblFaculty", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            }
            catch (Exception ex) { }

        }


        //------------------------------------------------------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  //------------------------------------------------------------------------------------------------------------------------

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtfname, "Please Enter Only Alphabets");
                return;
            }
            else
            {
                errorProvider1.SetError(txtfname, String.Empty);
            }
        }
 //------------------------------------------------------------------------------------------------------------------------   
        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(txtmname, "Please Enter Only Alphabets");
                return;
            }
            else
            {
                errorProvider2.SetError(txtmname, String.Empty);
            }
        }
//------------------------------------------------------------------------------------------------------------------------   
        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider3.SetError(txtlname, "Please Enter Only Alphabets");
                return;
            }
            else
            {
                errorProvider3.SetError(txtlname, String.Empty);
            }
        }
 //------------------------------------------------------------------------------------------------------------------------   
        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider4.SetError(txtcontact, "Please Enter Only Numbers");
                return;
            }
            else
            {
                errorProvider4.SetError(txtcontact, String.Empty);
            }
        }

        private void txtAddedby_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider8.SetError(txtAddedby, "Please Enter Only alphabets");
                return;
            }
            else
            {
                errorProvider8.SetError(txtAddedby, String.Empty);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                efid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                txtfname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtmname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtlname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtcontact.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtAddedby.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Click left side row..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("update tblFaculty set Fname='" + txtfname.Text + "',Mname='" + txtmname.Text + "',Lname='" + txtlname.Text + "',contact='" + txtcontact.Text + "',emailid='" + txtemail.Text + "',deptname='" + comboBox1.Text + "',ac_year='" + comboBox2.Text + "',addedBy='" + txtAddedby.Text + "' where FID=" + Convert.ToInt32(efid) + " ", con);
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
            txtcontact.Text = "";
            txtemail.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtmname.Text = "";
            txtAddedby.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("delete from tblFaculty where Did=" + Convert.ToInt32(efid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");
                clear();
                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        //------------------------------------------------------------------------------------------------------------------------   

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfname.Text.Trim()))
            {

                errorProvider1.SetError(txtfname, "Please Enter First Name!!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtfname, String.Empty);
            }
  //------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtmname.Text.Trim()))
            {

                errorProvider2.SetError(txtmname, "Please Enter Middle Name !");
                return;
            }
            else
            {

                errorProvider2.SetError(txtmname, String.Empty);
            }
 //------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtlname.Text.Trim()))
            {

                errorProvider3.SetError(txtlname, "Please Enter Last Name !");
                return;
            }
            else
            {

                errorProvider3.SetError(txtlname, String.Empty);
            }
 //------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtcontact.Text.Trim()))
            {

                errorProvider4.SetError(txtcontact, "Please Enter Contact No. !");
                return;
            }
            else
            {

                errorProvider4.SetError(txtcontact, String.Empty);
            }
 //------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {

                errorProvider5.SetError(txtemail, "Please Enter Email Address !");
                return;
            }
            else
            {

                errorProvider5.SetError(txtemail, String.Empty);
            }
 //------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {

                errorProvider6.SetError(comboBox1, "Please Select Department !");
                return;
            }
            else
            {

                errorProvider6.SetError(comboBox1, String.Empty);
            }
//------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(comboBox2.Text.Trim()))
            {

                errorProvider7.SetError(comboBox2, "Please Select Academic Year !");
                return;
            }
            else
            {

                errorProvider7.SetError(comboBox2, String.Empty);
            }
//------------------------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(txtAddedby.Text.Trim()))
            {

                errorProvider8.SetError(txtAddedby, "Please Enter Details !");
                return;
            }
            else
            {

                errorProvider8.SetError(txtAddedby, String.Empty);
            }
//------------------------------------------------------------------------------------------------------------------------
            if (txtcontact.Text.Length != 10)

            {
                errorProvider2.SetError(txtcontact, "PLease Enter Valid Phone Number");
                return;

            }
            else
            {
                errorProvider2.SetError(txtcontact, String.Empty);

            }

            //------------------------------------------------------------------------------------------------------------------------
            if (txtfname.Text == "" || txtmname.Text == "" || txtlname.Text == "" || txtcontact.Text == "" || txtemail.Text == "" || comboBox1.Text == "" || comboBox2.Text == ""|| txtAddedby.Text=="")
            {

                MessageBox.Show("Plz fill Details");
                //txtemail.Focus();

            }
//--------------------------DATAGRID----------------------------------------------------------------------------------------------

            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblFaculty(Fname,Mname,Lname,contact,emailid,deptname,ac_year,addedBy,created_date) values('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" +txtcontact.Text + "','" + txtemail.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','"+txtAddedby.Text+"','"+ DateTime.Now +"')", con);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Faculty Added..");
                clear();
                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show("Faculty Added.."+ ex.Message); }

           
        }

       
        public FacultyMst()
        {
            InitializeComponent();
        }

       

       
    }

}
