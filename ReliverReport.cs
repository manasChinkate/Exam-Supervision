using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using Microsoft.Reporting.WinForms;


namespace ExamSupervisionSystem
{
    public partial class ReliverReport : Form
    {
        SqlDataReader dr1, dr;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ReliverReport()
        {
            InitializeComponent();
        }

        private void ReliverReport_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True;");
            con.Open();
            cmd = new SqlCommand("select distinct faculty FROM tblreliever", con);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["faculty"].ToString());
            }
            dr.Close();
            this.reportViewer1.RefreshReport();
            con.Close();
        }

        

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True;");
          
            con.Open(); 
            //SqlCommand cmd = new SqlCommand("select * from tblreliever where faculty in (Select max(faculty) FROM tblreliever group by faculty ='" + comboBox1.Text + "') ", con);
           SqlCommand cmd = new SqlCommand("Select distinct(faculty),blockNo,roomNo from tblreliever  where faculty ='" + comboBox1.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet5", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\manas\Downloads\Exam\ExamSupervisionSystem\ReliverReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
