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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (txtmember.Text == "" || txtcontact.Text == "" || txtemail.Text == "" || txtcontact.Text == "" )

                MessageBox.Show("Plz fill Details");
                //txtemail.Focus();

            }
            try
            {
                con = new SqlConnection(@"Data Source=LAB2PC11\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True");
                cmd = new SqlCommand("insert into tblMember(member_name,contact,emailid,deptname,ac_year,role,) values('" + txtmember.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + txtAddedby.Text + "','" + DateTime.Now + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Faculty Added..");
                
                txtmember.Text = "";
                
                txtemail.Text = "";
                txtcontact.Text = "";

                comboBox1.Text = "";
                
                da = new SqlDataAdapter("select * from tblFaculty", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Show();
                con.Close();
private void Member_Load(object sender, EventArgs e)
        {

        }
    }
            catch (Exception ex) { MessageBox.Show("Member Added.." + ex.Message); }
        }
    }
    }
}
