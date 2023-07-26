using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ExamSupervisionSystem
{
    public partial class ExamMasterReport : Form
    {
        SqlDataReader dr1, dr;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ExamMasterReport()
        {
            InitializeComponent();
        }

        private void ExamMasterReport_Load(object sender, EventArgs e)
        {

            
            

            this.reportViewer1.RefreshReport();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EBJOLA8\SQLEXPRESS;Initial Catalog=ESP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblExam", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet6", dt);
            reportViewer1.LocalReport.ReportPath = @"E:\Exam\ExamSupervisionSystem\ExamReport1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
