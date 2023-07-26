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
    public partial class MDIParent1 : Form
    {
        //private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

      
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            panelTransaction.Visible = false;
            panelMaster.Visible = false;
            panelTools.Visible = false;
            panelReports.Visible = false;
            panelHelp.Visible = false;
        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login obj = new Login();
            //obj.Show();
            this.Hide();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-excel");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-word");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyMst ff = new FacultyMst();
            ff.MdiParent = this;
            ff.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment ff1 = new AddDepartment();
            ff1.MdiParent = this;
            ff1.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void addAcademicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddYear ff2 = new AddYear();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelTransaction.Visible = true;
            panelMaster.Visible = false;
            panelTools.Visible = false;
            panelReports.Visible = false;
            panelHelp.Visible = false;

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            AddYear ff2 = new AddYear();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelReports.Visible =false;
            panelTools.Visible = false;
            panelHelp.Visible =false;
            panelTransaction.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            panelMaster.Visible = true;
            panelTransaction.Visible = false;
            panelTools.Visible = false;
            panelReports.Visible = false;
            panelHelp.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panelTools.Visible = false;
            panelReports.Visible = false;
            panelTransaction.Visible = false;
            panelMaster.Visible = false;
            panelHelp.Visible = true;
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            panelTransaction.Visible = true;
            panelMaster.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panelReports.Visible=true;
            panelTransaction.Visible = false;
            panelMaster.Visible=false;
            panelTools.Visible=false;
            panelHelp.Visible = false;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panelTools.Visible=true;
            panelReports.Visible = false;
            panelTransaction.Visible = false;
            panelMaster.Visible = false;
            panelHelp.Visible = false;
        }

        private void bunifuFlatButton31_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memberMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            FacultyMst ff = new FacultyMst();
            ff.MdiParent = this;
            ff.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void examMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            AddDepartment ff1 = new AddDepartment();
            ff1.MdiParent = this;
            ff1.Show();

            panelMaster.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelTransaction.Visible = false;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facultyWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void examRecieptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-excel");

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-word");

        }

        private void btnMSword_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            login obj = new login();
           obj.Show();
            this.Hide();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {
            

            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panelTools.Visible = false;
            panelReports.Visible = false;
            panelTransaction.Visible = false;
            panelMaster.Visible = false;
            panelHelp.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_Click(object sender, EventArgs e)
        {
            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            AddBlockMst ff1 = new AddBlockMst();
            ff1.MdiParent = this;
            ff1.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            MemberMst ff2 = new MemberMst();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            AddReliver ff2 = new AddReliver();
            ff2.MdiParent = this;
            ff2.Show();
            
            
            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            DepartmentReport ff2 = new DepartmentReport();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            YearReport ff2 = new YearReport();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Report ff2 = new Report();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            FacultyReport ff2 = new FacultyReport();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            ReliverReport ff2 = new ReliverReport();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            ExamMasterReport ff2 = new ExamMasterReport();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            SupervisionReport ff2 = new SupervisionReport();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            ExamMaster ff2 = new ExamMaster();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            SupervisionDetails ff2 = new SupervisionDetails();
            ff2.MdiParent = this;
            ff2.Show();

            panelMaster.Visible = false;
            panelTransaction.Visible = false;
            panelReports.Visible = false;
            panelTools.Visible = false;
            panelHelp.Visible = false;
            panelReports.Visible = false;
        }
    }
}
