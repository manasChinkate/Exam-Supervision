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

namespace ExamSupervisionSystem
{
    public partial class AddDepartment : Form
    {
        SqlConnection con;
        SqlCommand cmd,cmd1;
        SqlDataAdapter da;
        DataTable dt;
        static int edid;
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
     //--------------------------------VALIDATION--------------------------------------------------------------       
            
           

            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {

                errorProvider2.SetError(comboBox1, "Please Select Department Name !");
                return;
            }
            else
            {

                errorProvider2.SetError(comboBox1, String.Empty);
            }


//-----------------------------------------DATABASE-----------------------------------------------------------------------

            
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblDept(Dname)values('" + comboBox1.SelectedItem.ToString() + "','" + DateTime.Now + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dept Added..");
                
                comboBox1.Text = "";
               
                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show("Dept Added.." + ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   


        public void ShowData()
        {
            try {
                con.Open();
                da = new SqlDataAdapter("select * from tblDept", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();

            } catch (Exception ex) { }
        
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
            ShowData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                edid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                bunifuFlatButton2.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Click left side row..");
            }
      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("update tblDept set Dname='" +comboBox1.Text+ "' where Did=" + Convert.ToInt32(edid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Updated....");
                comboBox1.Text = "";
                
                con.Close();
                ShowData();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("delete from tblDept where Did=" + Convert.ToInt32(edid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");
                comboBox1.Text = "";
               
                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
