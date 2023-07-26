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
    public partial class AddBlockMst : Form
    {
        SqlConnection con;
        SqlCommand cmd,cmd1;
        SqlDataAdapter da;
        DataTable dt;
        static int ebid;
        public AddBlockMst()
        {
            InitializeComponent();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddblock_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtbnumber.Text.Trim()))
            {
                
                errorProvider1.SetError(txtbnumber, "Please Enter Block Number");
                return;
            }
            else
            {
                
                errorProvider1.SetError(txtbnumber, String.Empty);
            }

            if (string.IsNullOrEmpty(txtrnumber.Text.Trim()))
            {

                errorProvider2.SetError(txtrnumber, "Please Enter Room Number");
                return;
            }
            else
            {

                errorProvider2.SetError(txtrnumber, String.Empty);
            }



            if (txtbnumber.Text == "" || txtrnumber.Text == "")
            {

                MessageBox.Show("Plz fill Details");
                txtbnumber.Focus();
                txtrnumber.Focus();
            }
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblAddBlockNo(BlockNo,RoomNo)values(" + Convert.ToInt32(txtbnumber.Text) + "," + Convert.ToInt32(txtrnumber.Text) + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Block No Added..");
                txtbnumber.Text = "";
                txtrnumber.Text = "";
               
                con.Close();
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void ShowData()
        {
            try {
                con.Open();
                da = new SqlDataAdapter("select * from tblAddBlockNo", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();
            } catch (Exception ex) { }
        }

        private void txtbnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(txtbnumber, "Please Enter Only Numbers");
                return;
            }
            else
            {
                errorProvider2.SetError(txtbnumber, String.Empty);
            }
        }

        private void txtrnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(txtrnumber, "Please Enter Only Numbers");
                return;
            }
            else
            {
                errorProvider2.SetError(txtrnumber, String.Empty);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                cmd1 = new SqlCommand("update tblAddBlockNo set BlockNo=" + Convert.ToInt32(txtbnumber.Text)+ ",RoomNo=" + Convert.ToInt32(txtrnumber.Text) + " where bid="+Convert.ToInt32(ebid)+" ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Updated....");
                txtbnumber.Text = "";
                txtrnumber.Text = "";
                con.Close();
                ShowData();
            } catch (Exception ex) { }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ebid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                txtbnumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtrnumber.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                btnaddblock.Enabled = false;
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show("Please Click left side row..");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd1 = new SqlCommand("delete from tblAddBlockNo where bid=" + Convert.ToInt32(ebid) + " ", con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Deleted....");
                txtbnumber.Text = "";
                txtrnumber.Text = "";
                con.Close();
                ShowData();
            }
            catch (Exception ex) { }
        }

        private void AddBlockMst_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
            ShowData();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }
    }
}
